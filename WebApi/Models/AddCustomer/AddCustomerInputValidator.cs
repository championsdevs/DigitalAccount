using FluentValidation;
using static Domain.Entities.Customer;

namespace WebApi.Models.AddCustomer
{
    public class AddCustomerInputValidator : AbstractValidator<AddCustomerInput>
    {
        public AddCustomerInputValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Email).EmailAddress();
            RuleFor(c => c.Document).IsValidCPF().WithMessage("'Document' é um CPF inválido.");
            RuleFor(c => c.CustomerType).IsInEnum();
            RuleFor(c => (int)c.CustomerType).InclusiveBetween((int)CustomerType.Physical, (int)CustomerType.Juridical);
        }
    }
}
