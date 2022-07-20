using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Service.Dtos.Customers
{
    public class CustomerModel
    {
        public long Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
