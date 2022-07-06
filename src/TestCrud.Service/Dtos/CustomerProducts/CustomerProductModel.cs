using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Service.Dtos.CustomerProducts
{
    public class CustomerProductModel
    {
        public long Id { get; set; }
        public int RegisterationNumber { get; set; }
        public long ProductId { get; set; }
        public long CustomerId { get; set; }
    }
}
