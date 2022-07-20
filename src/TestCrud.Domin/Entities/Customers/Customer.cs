using Crud.Domin.Entities.CustomerProducts;
using System;
using System.Collections.Generic;

namespace Crud.Domin.Entities.Customers
{
    public class Customer : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public ICollection<CustomerProduct> CustomerProducts{ get; set; }
    }
}
