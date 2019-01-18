using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Common.Attributes
{
    public class ApiDocumentAttribute : Attribute
    {
        public string GroupName { get; set; }
    }
}
