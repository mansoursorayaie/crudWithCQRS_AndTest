using Crud.Service.Dtos.CustomerProducts;
using FluentValidation;

namespace Crud.Service.Validatiors.CustomerProducts
{
    public class CustomerProductValidator : AbstractValidator<CustomerProductModel>
    {
        public CustomerProductValidator()
        {
            RuleFor(x => x.RegisterationNumber).NotNull();
            RuleFor(x => x.ProductId).NotNull();
            RuleFor(x => x.CustomerId).NotNull();
        }
    }
}
