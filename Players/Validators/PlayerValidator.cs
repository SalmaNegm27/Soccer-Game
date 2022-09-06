namespace Players.Validators
{
   
    public class PlayerValidator :AbstractValidator<PlayerViewModel>
    {
        public PlayerValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name can not be empty");
            RuleFor(p => p.Nationality).NotEmpty().WithMessage("Nationality can not be empty");


        }
    }
}
