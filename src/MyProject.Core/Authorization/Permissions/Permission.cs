using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Authorization.Permissions
{
    [Table("Permissions")]
    public class Permission : FullAuditedEntity
    {
        public Permission() { }
        public Permission(string code, string name)
        {
            Code = code;
            Name = name;
        }
        [Required]
        [MaxLength(32)]
        public string Code { get; set; }
        [Required]
        [MaxLength(64)]
        public string FullCode { get; set; }
        [Required]
        [MaxLength(32)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string Url { get; set; }
        [MaxLength(256)]
        public string Icon { get; set; }
        public int Index { get; set; }
        [MaxLength(64)]
        public string TreeIndex { get; set; }

        public EnumPermissionType Type { get; set; }

        public int? ParentId { get; set; }
        [ForeignKey("ParentId")]
        public Permission Parent { get; set; }
        [MaxLength(256)]
        public string Note { get; set; }
        public List<Permission> Children { get; set; } = new List<Permission>();
    }
}
