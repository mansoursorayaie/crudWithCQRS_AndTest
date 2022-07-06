using Crud.Domin.Entities.CustomerProducts;
using Crud.Domin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Domin.Entities.Products
{
    public class Product : BaseEntity
    {
        public string  Name{ get; set; }
        public ProductType ProductType { get; set; }
        public ICollection<CustomerProduct> CustomerProducts{ get; set; }

    }
}
