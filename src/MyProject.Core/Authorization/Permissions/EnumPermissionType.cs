using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyProject.Authorization.Permissions
{
    public enum EnumPermissionType
    {
        [Display(Name = "模块")]
        Module = 1,
        [Display(Name = "页面")]
        Page = 2,
        [Display(Name = "操作")]
        Action = 3
    }
}
