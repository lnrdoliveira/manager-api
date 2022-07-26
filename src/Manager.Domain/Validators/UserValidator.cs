using FluentValidation;

namespace Manager.Domain.Validators{

    public class UserValidator : AbstractValidator<Entities.User>
    {
        public UserValidator()
        {
                RuleFor(x => x)
                    .NotEmpty()
                    .WithMessage("A entidade não pode ser vazia.")
                    .NotNull()
                    .WithMessage("A entidade não pode ser nula.");

                RuleFor(x => x.Name)
                    .NotNull()
                    .WithMessage("O nome não pode ser nulo.")
                    .NotEmpty()
                    .WithMessage("O nome não pode ser vazio.")
                    .MinimumLength(3)
                    .WithMessage("O nome deve ter pelo menos 3 caracteres.")
                    .MaximumLength(80)
                    .WithMessage("O nome pode ter no máxmo 80 caracteres.");

                RuleFor(x => x.Password)
                    .NotNull()
                    .WithMessage("A senha nã pode ser nula.")
                    .NotEmpty()
                    .WithMessage("A senha não pode ser vazia.")
                    .MinimumLength(6)
                    .WithMessage("A senha deve ter no mínimo 6 caracteres.")
                    .MaximumLength(80)
                    .WithMessage("A senha deve ter no máximo 80 caracteres.");

                RuleFor(x=> x.Email)
                    .NotNull()
                    .WithMessage("O e-mail não pode ser nulo.")
                    .NotEmpty()
                    .WithMessage("O e-mail não pode ser vazio.")
                    .MinimumLength(10)
                    .WithMessage("O e-mail deve ter no mínimo 10 caracteres.")
                    .MaximumLength(180)
                    .WithMessage("O e-mail pode ter no máximo 180 caracteres.")
                    .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                    .WithMessage("O e-mail informado não é válido.");


        }
    }
}