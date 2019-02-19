using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.ObjectMapping;

using MyProject.Authorization.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyProject.Authorization
{
    public interface IPermissionAppService : IApplicationService
    {
        Task<List<PermissionDto>> GetMenues();
    }
    public class PermissionAppService : ApplicationService, IPermissionAppService
    {
        private Permissions.IPermissionManager _permissionManager;
        public PermissionAppService(Permissions.IPermissionManager permissionManager)
        {
            _permissionManager = permissionManager;
        }

        /// <summary>
        /// 获取登录用户可见菜单权限
        /// </summary>
        /// <returns></returns>
        public async Task<List<PermissionDto>> GetMenues()
        {
            var menues = await _permissionManager.GetMenues();
            var dtoList = menues.Select(t => ObjectMapper.Map<PermissionDto>(t)).ToList();

            //var user = await UserRepository.FirstOrDefaultAsync(AbpSession.UserId.GetValueOrDefault());
            //if (user?.ProjectId != null)
            //{
            //    // 如果是市政行业，中间交工改名为计量签证。
            //    var project = await ProjectRepository.FirstOrDefaultAsync(user.ProjectId.Value);
            //    if (project != null && project.IndustryType == Projects.IndustryType.Manicipal)
            //    {
            //        dtoList.ForEach(t => UpdateMenuName(t));
            //    }
            //}

            return dtoList;
        }

    }
}
