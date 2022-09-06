namespace Teams.Validators
{


    public class ClubValidator : AbstractValidator<ClubViewModel>
    {
        public ClubValidator()
        {

            RuleFor(cl => cl.Name).NotEmpty().WithMessage("Name can not be empty");
            RuleFor(cl=> cl.Country).NotEmpty().WithMessage("Country can not be empty");
        }
    }
}