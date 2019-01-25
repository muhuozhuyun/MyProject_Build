using Abp.Domain.Entities;
using Abp.Organizations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Products
{
    [Table("Products")]
    public class Product : Entity, IMustHaveTenant, IMustHaveOrganizationUnit
    {
        public virtual int TenantId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual long OrganizationUnitId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public virtual string Name { get; set; }

        public virtual float Price { get; set; }
    }
}
