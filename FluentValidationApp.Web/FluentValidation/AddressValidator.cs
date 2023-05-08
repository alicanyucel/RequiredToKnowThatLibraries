using FluentValidation;
using FluentValidationApp.Web.Models;

namespace FluentValidationApp.Web.FluentValidation
{
    public class AddressValidator:AbstractValidator<Address>
    {
        public string NotEmptyMessage { get; } = "Not empty for place of {PropertyName}";
        public AddressValidator()
        {
            RuleFor(A => A.AddressDetail).NotEmpty();
            RuleFor(A => A.Province).NotEmpty();
            RuleFor(A => A.PostCode).NotEmpty().MaximumLength(5).WithMessage("{PropertyName}'s placeHolder is required for {MaxLength} character.");
        }
    }
}
