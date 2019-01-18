using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Castle.Facilities.Logging;
using Abp.AspNetCore;
using Abp.Castle.Logging.Log4Net;
using MyProject.Authentication.JwtBearer;
using MyProject.Configuration;
using MyProject.Identity;
using MyProject.Web.Resources;
using Abp.AspNetCore.SignalR.Hubs;
using Swashbuckle.AspNetCore.Swagger;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;
using MyProject.Common.Attributes;

namespace MyProject.Web.Startup
{
    public class Startup
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Startup(IHostingEnvironment env)
        {
            _appConfiguration = env.GetAppConfiguration();
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            // MVC
            services.AddMvc(
                options => options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute())
            );

            IdentityRegistrar.Register(services);
            AuthConfigurer.Configure(services, _appConfiguration);

            services.AddScoped<IWebResourceManager, WebResourceManager>();

            services.AddSignalR();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Title = "AbpZeroTemplate API",
                    Description = "提供移动端或其它系统集成到自定义平台需要的api接口。",
                    Version = "v1"
                });
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "MyProject.Application.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "MyProject.Web.Core.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "MyProject.Web.Mvc.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "MyProject.Common.xml"));
               // options.DocInclusionPredicate((docName, description) => true);
                options.TagActionsBy(api =>
                {
                    MethodInfo methodInfo;
                    api.TryGetMethodInfo(out methodInfo);
                    var attr = methodInfo.GetCustomAttributes<ApiDocumentAttribute>().FirstOrDefault() ??
                    methodInfo.DeclaringType.GetCustomAttributes<ApiDocumentAttribute>().FirstOrDefault();

                    return new List<string> { attr.GroupName ?? api.GroupName };
                });
                options.OrderActionsBy((apiDesc) => $"{apiDesc.ActionDescriptor.RouteValues["controller"]}_{apiDesc.HttpMethod}");
                options.DescribeAllEnumsAsStrings();
                options.DocInclusionPredicate((docName, description) =>
                {
                    MethodInfo methodInfo;
                    description.TryGetMethodInfo(out methodInfo);
                    var attrs = methodInfo.GetCustomAttributes<ApiDocumentAttribute>();
                    if (attrs.Any())
                    {
                        return true;
                    }
                    else
                    {
                        attrs = methodInfo.DeclaringType.GetCustomAttributes<ApiDocumentAttribute>();
                        return attrs.Any();
                    }
                });
                options.CustomSchemaIds(x => x.FullName);
                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });
          
            // Configure Abp and Dependency Injection
            return services.AddAbp<MyProjectWebMvcModule>(
                // Configure Log4Net logging
                options => options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                    f => f.UseAbpLog4Net().WithConfig("log4net.config")
                )
            );


        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseAbp(); // Initializes ABP framework.

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseJwtTokenMiddleware();

            app.UseSignalR(routes =>
            {
                routes.MapHub<AbpCommonHub>("/signalr");
            });
            app.UseSwagger();
            //Enable middleware to serve swagger - ui assets(HTML, JS, CSS etc.)
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "AbpZeroTemplate API V1");
            }); //URL: /swagger 

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "defaultWithArea",
                    template: "{area}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
