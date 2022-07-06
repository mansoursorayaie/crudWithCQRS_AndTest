using Crud.Domin.Entities.CustomerProducts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crud.Domin.Configurations.CustomerProducts
{
    public class CustomerProductConfig : IEntityTypeConfiguration<CustomerProduct>
    {
        public void Configure(EntityTypeBuilder<CustomerProduct> builder)
        {

        }
    }
}
