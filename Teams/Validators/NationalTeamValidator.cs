namespace Teams.Validators
{
    
    public class NationalTeamValidator :AbstractValidator<NationalTeamViewModel>
    {
        public NationalTeamValidator()
        {

            RuleFor(n => n.Name).NotEmpty().WithMessage("Name can not be empty");
            RuleFor(n=>n.Country).NotEmpty().WithMessage("Country can not be empty");
        }
    }
}
