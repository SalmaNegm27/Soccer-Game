namespace Coaches.Validators
{
    

    public class CoachValidator :AbstractValidator<CoachViewModel>
    {
        public CoachValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().MaximumLength(10).WithMessage("Name can not be empty");
            RuleFor(p => p.LastName).NotEmpty().MaximumLength(10).WithMessage("Nationality can not be empty");
            RuleFor(p => p.PhoneNumber).NotEmpty().MaximumLength(11);

        }
    }
}
