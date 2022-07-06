using Crud.Domin.Entities.Customers;
using Crud.Domin.Entities.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Domin.Entities.CustomerProducts
{
    public class CustomerProduct : BaseEntity
    {
        public int RegisterationNumber { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
