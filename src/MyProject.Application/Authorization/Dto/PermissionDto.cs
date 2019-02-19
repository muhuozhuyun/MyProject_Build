using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using MyProject.Authorization.Permissions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyProject.Authorization.Dto
{
    [AutoMap(typeof(Permissions.Permission))]
    public class PermissionDto : EntityDto
    {
        [Required]
        [MaxLength(32)]
        public string Code { get; set; }

        [MaxLength(64)]
        public string FullCode { get; set; }

        [Required]
        [MaxLength(32)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Url { get; set; }

        [MaxLength(256)]
        public string Icon { get; set; }

        public EnumPermissionType Type { get; set; }
        //public string TypeName { get { return Type.GetDisplayName(); } }

        public int? ParentId { get; set; }

        public int? Index { get; set; }

        public string TreeIndex { get; set; }

        [MaxLength(256)]
        public string Note { get; set; }

        public List<PermissionDto> Children
        { get; set; } = new List<PermissionDto>();
    }
}
