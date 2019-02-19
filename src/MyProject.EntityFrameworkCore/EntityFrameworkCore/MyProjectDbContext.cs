using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyProject.Authorization.Roles;
using MyProject.Authorization.Users;
using MyProject.MultiTenancy;
using MyProject.Products;
using Abp.Authorization;

namespace MyProject.EntityFrameworkCore
{
    public class MyProjectDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public MyProjectDbContext(DbContextOptions<MyProjectDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } //产品
        public DbSet<Authorization.Permissions.Permission> Permission { get; set; }
        public DbSet<Authorization.Permissions.PermissionSetting> PermissionSettings { get; set; }
    }
}
