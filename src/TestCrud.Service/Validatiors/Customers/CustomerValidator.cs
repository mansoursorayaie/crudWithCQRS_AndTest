using Crud.Service.Dtos.Customers;
using FluentValidation;
using FluentValidation.Validators;
using System.Text.RegularExpressions;

namespace Crud.Service.Validatiors.Customers
{
    public class CustomerValidator : AbstractValidator<CustomerModel>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Lastname).NotEmpty();
            RuleFor(x => x.DateOfBirth).NotEmpty();
            RuleFor(x => x.Email).EmailAddress(EmailValidationMode.AspNetCoreCompatible);
            RuleFor(x => x.PhoneNumber).NotNull()
                .Matches(new Regex(@"^(0|0098|\+98)9(0[1-5]|[1 3]\d|2[0-2]|98)\d{7}$")).WithMessage("PhoneNumber not valid"); ;
        }
    }

}
