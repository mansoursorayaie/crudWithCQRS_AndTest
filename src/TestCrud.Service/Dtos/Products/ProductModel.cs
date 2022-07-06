using Crud.Domin.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Service.Dtos.Products
{
    public class ProductModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ProductType ProductType { get; set; }
    }
}
