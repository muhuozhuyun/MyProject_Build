using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.Runtime.Session;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using MyProject.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Authorization.Permissions
{
    public interface IPermissionManager : IDomainService
    {
        IList<Permission> GetModuleAndPagePermissions(int projectId);

        List<Permission> GetAllRootPermissions();
        Task<Permission> Get(int id);
        Task<List<Permission>> GetAll();
        Task<List<Permission>> GetMenues();
        //List<Permission> GetTree();
        Task Create(Permission permission);
        Task Update(Permission permission);
        Task Delete(int id);

        bool IsGranted(long userId, string permissionCode);
        Task<List<string>> GetUserGrantedPermissionCodes(long userId);

        Task SaveUserPermissions(long userId, Permission[] permissions);
        List<string> GetRolePermissionCodes(int roleId);
        Task SaveRolePermissions(int roleId, Permission[] permissions);

        Task<List<Permission>> GetProjectPermissions(int projectId);
        List<string> GetProjectPermissionCodes(int projectId);

        Task SaveProjectPermissions(int projectId, Permission[] permissions);
    }
    public class PermissionManager : DomainService, IPermissionManager
    {
        private IRepository<Permission> _permissionRepo;
        private IRepository<User, long> _userRepo;
        private IRepository<PermissionSetting> _permissionSettingRepo;
        private IAbpSession _session;

        public PermissionManager(
            IAbpSession session,
            IRepository<User, long> userRepo,
            IRepository<Permission> permissionRepo,
            IRepository<PermissionSetting> permissionSettingRepo
            )
        {
            _session = session;
            _userRepo = userRepo;
            _permissionRepo = permissionRepo;
            _permissionSettingRepo = permissionSettingRepo;
        }

        public async Task<Permission> Get(int id)
        {
            return await _permissionRepo.GetAsync(id);
        }

        /// <summary>
        /// 获取所有模块和页面权限
        /// </summary>
        /// <returns></returns>
        public IList<Permission> GetModuleAndPagePermissions(int projectId)
        {
            var permissions = _permissionRepo.GetAll()
                .Where(t => t.Type == EnumPermissionType.Module
                || t.Type == EnumPermissionType.Page)
                .AsNoTracking().ToList();

            var permissionSettings = _permissionSettingRepo.GetAll()
                //.Where(t => t.ProjectId == projectId)
                .ToList();
            CopyCustomInfo(permissions, permissionSettings);

            return SortPermissions(permissions);
        }

        private void CopyCustomInfo(List<Permission> permissions, List<PermissionSetting> permissionSettings)
        {
            foreach (var permission in permissions)
            {
                var permissionSetting = permissionSettings.FirstOrDefault(t => t.PermissionCode == permission.FullCode);
                if (permissionSetting != null && permissionSetting.Index.GetValueOrDefault() > 0)
                {
                    permission.Index = permissionSetting.Index.Value;
                }
                if (permissionSetting != null && !string.IsNullOrWhiteSpace(permissionSetting.Name))
                {
                    permission.Name = permissionSetting.Name;
                }
                if (permissionSetting != null && !string.IsNullOrWhiteSpace(permissionSetting.Url))
                {
                    permission.Url = permissionSetting.Url;
                }
            }
        }

        /// <summary>
        /// 获取当前登录用户可见菜单
        /// </summary>
        /// <returns></returns>
        public async Task<List<Permission>> GetMenues()
        {
            var userId = _session.GetUserId();
            var menues = await GetUserGrantedMenues(userId);

            return menues.Where(t => t.Type == EnumPermissionType.Module).OrderBy(t => t.Index).ToList();
        }

        private async Task<List<Permission>> GetUserGrantedMenues(long userId)
        {
            var permissions = new List<Permission>();
            var user = await _userRepo.GetAllIncluding(t => t.Roles).FirstOrDefaultAsync(t => t.Id == userId);
            if (user == null)
            {
                throw new UserFriendlyException($"用户'{userId}'不存在。");
            }

            if (user.IsSystemAdmin())
            {
                // 系统管理员直接获取所有权限
                permissions = _permissionRepo.GetAll().Where(t => t.Type == EnumPermissionType.Module || t.Type == EnumPermissionType.Page).ToList();
            }
            else
            {
                // 非系统管员
                var roleIds = user.Roles.Select(t => t.RoleId).ToList();

                // 用户权限
                var userPermissionCodes = _permissionSettingRepo.GetAll().Where(t => t.UserId == userId).Select(t => t.PermissionCode).ToList();

                // 用户角色权限
                var rolePermissionCodes = _permissionSettingRepo.GetAll().Where(t => roleIds.Contains(t.RoleId.Value)).Select(t => t.PermissionCode).ToList();

                var projectId = user.ProjectId.GetValueOrDefault();
                // 项目权限
                var projectPermissionCodes = GetProjectPermissionCodes(projectId);
                var projectCustoms = _permissionSettingRepo.GetAll()
                    .Where(t => t.ProjectId == projectId && projectPermissionCodes.Contains(t.PermissionCode))
                    .ToList();

                // 是否授权 = 项目持有权限 “并且” (用户“或者”用户角色持有权限)
                var permissionCodes = (userPermissionCodes.Union(rolePermissionCodes)).Intersect(projectPermissionCodes);

                var permissionQuery = _permissionRepo.GetAll().Where(t => permissionCodes.Contains(t.FullCode) && (t.Type == EnumPermissionType.Module || t.Type == EnumPermissionType.Page));

                permissions = permissionQuery.AsNoTracking().ToList();

                CopyCustomInfo(permissions, projectCustoms);
            }

            return SortPermissions(permissions);
        }

        /// <summary>
        /// 获取所有权限
        /// </summary>
        /// <returns></returns>
        public async Task<List<Permission>> GetAll()
        {
            var permissions = await _permissionRepo.GetAllListAsync();
            var sortedPermissions = SortPermissions(permissions);
            return sortedPermissions;
        }

        public List<Permission> GetAllRootPermissions()
        {
            var permissions = _permissionRepo.GetAllList();
            return permissions.Where(t => t.ParentId == null).OrderBy(t => t.Index).ToList();
        }

        private List<Permission> SortPermissions(List<Permission> permissions)
        {
            var result = new List<Permission>();
            var roots = permissions.Where(t => t.ParentId == null).OrderBy(t => t.Index);
            foreach (var root in roots)
            {
                SortChildren(root, result, permissions);
            }

            return result;
        }

        private void SortChildren(Permission permission, List<Permission> result, List<Permission> permissions)
        {
            result.Add(permission);
            var children = permissions.Where(t => t.ParentId == permission.Id).OrderBy(t => t.Index);
            permission.Children = children.ToList();
            if (children.Any())
            {
                foreach (var child in children)
                {
                    SortChildren(child, result, permissions);
                }
            }
        }

        public async Task Create(Permission permission)
        {
            permission.FullCode = permission.Code;
            Permission parent = null;
            if (permission.ParentId != null)
            {
                parent = _permissionRepo.Get(permission.ParentId.Value);
            }

            if (parent != null)
            {
                parent = _permissionRepo.Get(permission.ParentId.Value);
                permission.FullCode = parent.FullCode + "." + permission.Code;
            }

            if (_permissionRepo.GetAll().Any(t => t.FullCode == permission.FullCode))
            {
                throw new UserFriendlyException($"权限代码'{permission.FullCode}'已存在。");
            }

            if (permission.Index <= 0)
            {
                var maxIndex = _permissionRepo.GetAll().Where(t => t.ParentId == permission.ParentId).Select(t => t.Index).DefaultIfEmpty(0).Max();
                permission.Index = maxIndex + 1;
            }
            permission.TreeIndex = permission.Index.ToString();
            if (parent != null)
            {
                permission.TreeIndex = parent.TreeIndex.ToString() + "-" + permission.Index.ToString();
            }
            await _permissionRepo.InsertAsync(permission);
            await CurrentUnitOfWork.SaveChangesAsync();
        }

        public async Task Update(Permission permission)
        {
            permission.FullCode = permission.Code;
            Permission parent = null;
            if (permission.ParentId != null)
            {
                parent = _permissionRepo.Get(permission.ParentId.Value);
            }

            if (parent != null)
            {
                parent = _permissionRepo.Get(permission.ParentId.Value);
                permission.FullCode = parent.FullCode + "." + permission.Code;
            }

            if (_permissionRepo.GetAll().Any(t => t.Id != permission.Id && t.FullCode == permission.FullCode))
            {
                throw new UserFriendlyException($"权限代码'{permission.FullCode}'已存在。");
            }

            if (permission.Index <= 0)
            {
                var maxIndex = _permissionRepo.GetAll().Where(t => t.ParentId == permission.ParentId).Select(t => t.Index).DefaultIfEmpty(0).Max();
                permission.Index = maxIndex + 1;
            }

            permission.TreeIndex = permission.Index.ToString();
            if (parent != null)
            {
                permission.TreeIndex = parent.TreeIndex.ToString() + "-" + permission.Index.ToString();
            }
            await _permissionRepo.UpdateAsync(permission);
            await CurrentUnitOfWork.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await _permissionRepo.DeleteAsync(id);
        }

        /// <summary>
        /// 是否授权
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permissionCode"></param>
        /// <returns></returns>
        public bool IsGranted(long userId, string permissionCode)
        {
            var user = _userRepo
                .GetAllIncluding(t => t.Roles)
                .FirstOrDefault(t => t.Id == userId);
            var roleIds = user.Roles.Select(t => t.Id).ToList();

            if (user.IsSystemAdmin())
            {
                // 系统管理员拥有所有权限
                return true;
            }

            return _permissionSettingRepo.GetAll()
                .Any(t => (t.UserId == userId || roleIds.Contains(t.RoleId.Value))  // 用户或角色拥有权限
                && t.PermissionCode == permissionCode);
        }

        /// <summary>
        /// 获取用户(包含其角色)持有的所有权限
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<List<string>> GetUserGrantedPermissionCodes(long userId)
        {
            var userPermissions = await GetUserGrantedPermissions(userId);
            return userPermissions.Select(t => t.FullCode).ToList();
        }

        private async Task<List<Permission>> GetUserGrantedPermissions(long userId)
        {
            var permissions = new List<Permission>();
            var user = await _userRepo.GetAllIncluding(t => t.Roles).FirstOrDefaultAsync(t => t.Id == userId);
            if (user == null)
            {
                throw new UserFriendlyException($"用户'{userId}'不存在。");
            }

            if (user.IsSystemAdmin())
            {
                // 系统管理员直接获取所有权限
                permissions = await _permissionRepo.GetAllListAsync();
            }
            else
            {
                // 非系统管员
                var roleIds = user.Roles.Select(t => t.RoleId).ToList();

                // 用户权限
                var userPermissionCodes = _permissionSettingRepo.GetAll().Where(t => t.UserId == userId).Select(t => t.PermissionCode).ToList();

                // 用户角色权限
                var rolePermissionCodes = _permissionSettingRepo.GetAll().Where(t => roleIds.Contains(t.RoleId.Value)).Select(t => t.PermissionCode).ToList();

                // 项目权限
                var projectPermissionCodes = GetProjectPermissionCodes(user.ProjectId.GetValueOrDefault());

                // 是否授权 = 项目持有权限 “并且” (用户“或者”用户角色持有权限)
                var permissionCodes = (userPermissionCodes.Union(rolePermissionCodes)).Intersect(projectPermissionCodes);

                var permissionQuery = _permissionRepo.GetAll().Where(t => permissionCodes.Contains(t.FullCode));

                permissions = permissionQuery.AsNoTracking().ToList();
            }

            return SortPermissions(permissions);
        }

        #region 用户权限配置
        /// <summary>
        /// 保存用户权限
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="permissions"></param>
        /// <returns></returns>
        public async Task SaveUserPermissions(long userId, Permission[] permissions)
        {
            await _permissionSettingRepo.DeleteAsync(t => t.UserId == userId);
            foreach (var permission in permissions)
            {
                await _permissionSettingRepo.InsertAsync(new PermissionSetting
                {
                    UserId = userId,
                    PermissionId = permission.Id,
                    PermissionCode = permission.FullCode
                });
            }
        }
        #endregion

        #region 角色权限配置
        public List<string> GetRolePermissionCodes(int roleId)
        {
            return _permissionSettingRepo.GetAll().Where(t => t.RoleId == roleId).Select(t => t.PermissionCode).ToList();
        }
        public async Task SaveRolePermissions(int roleId, Permission[] permissions)
        {
            await _permissionSettingRepo.DeleteAsync(t => t.RoleId == roleId);
            foreach (var permission in permissions)
            {
                await _permissionSettingRepo.InsertAsync(new PermissionSetting
                {
                    RoleId = roleId,
                    PermissionId = permission.Id,
                    PermissionCode = permission.FullCode
                });
            }
        }
        #endregion

        #region 项目权限配置

        /// <summary>
        /// 获取项目配置的权限
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public async Task<List<Permission>> GetProjectPermissions(int projectId)
        {
            var permissionCodes = _permissionSettingRepo.GetAll()
                .Where(t => t.ProjectId == projectId)
                .Select(t => t.PermissionCode)
                .ToList();

            // 页面上项目只能被赋予模块或页面权限，操作权限自动被包含在项目可用权限中
            var projectPermissions = _permissionRepo.GetAllIncluding(t => t.Parent).Where(t => permissionCodes.Contains(t.FullCode) || (t.Type == EnumPermissionType.Action && permissionCodes.Contains(t.Parent.FullCode))).ToList();

            return SortPermissions(projectPermissions);
        }

        public List<string> GetProjectPermissionCodes(int projectId)
        {
            var permissionCodes = _permissionSettingRepo.GetAll()
                .Where(t => t.ProjectId == projectId)
                .Select(t => t.PermissionCode)
                .ToList();

            // 页面上项目只能被赋予模块或页面权限，操作权限自动被包含在项目可用权限中
            return _permissionRepo.GetAllIncluding(t => t.Parent).Where(t => permissionCodes.Contains(t.FullCode) || (t.Type == EnumPermissionType.Action && permissionCodes.Contains(t.Parent.FullCode))).Select(t => t.FullCode).ToList();
        }

        public async Task SaveProjectPermissions(int projectId, Permission[] permissions)
        {
            await _permissionSettingRepo.DeleteAsync(t => t.ProjectId == projectId);
            foreach (var permission in permissions)
            {
                await _permissionSettingRepo.InsertAsync(new PermissionSetting
                {
                    ProjectId = projectId,
                    PermissionId = permission.Id,
                    PermissionCode = permission.FullCode,
                    Url = permission.Url,
                    Index = permission.Index,
                    Name = permission.Name
                });
            }
        }
        #endregion
    }
}
