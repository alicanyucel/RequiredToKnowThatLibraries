using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public string NotEmptyMessage { get; } = "Not empty for place of {PropertyName}";
        public CustomerValidator()
        {
            RuleFor(c => c.Name).NotEmpty().WithMessage(NotEmptyMessage);
            RuleFor(c => c.Email).NotEmpty().WithMessage(NotEmptyMessage).EmailAddress();
            RuleFor(c => c.Age).NotEmpty().WithMessage(NotEmptyMessage).InclusiveBetween(18,60);
            RuleFor(c => c.DateOfBirth).NotEmpty().WithMessage(NotEmptyMessage).Must(c =>
            {
                return DateTime.Now.AddYears(-18) >= c;
            }).WithMessage("Your Age is Required To Greater Than 18");

            RuleFor(c=>c.Gender).IsInEnum().WithMessage("{PropertyName} placeholder are takes  value for man=1 and takes value for woman=2.");

            RuleForEach(c=> c.Address).SetValidator(new AddressValidator());
        }
    }
}
