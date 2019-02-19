using Abp.Domain.Entities.Auditing;
using MyProject.Authorization.Roles;
using MyProject.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Authorization.Permissions
{
    public class PermissionSetting : AuditedEntity
    {
        public int PermissionId { get; set; }
        public Permission Permission { get; set; }
        public string PermissionCode { get; set; }
        public long? UserId { get; set; }
        public User User { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public int? ProjectId { get; set; }
        //public Projects.Project Project { get; set; }

        [MaxLength(256)]
        public string Url { get; set; }

        public int? Index { get; set; }

        [MaxLength(32)]
        public string Name { get; set; }
    }
}
