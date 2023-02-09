using FluentValidation;
using FunWithSerialization.Models;

namespace FunWithSerialization.Models.Validation
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x => x.FirstName)
                .NotNull()
                .Matches("^^[A-ZĄĆĘŁŃÓŚŹŻ][a-ząćęłńóśźż]*$")
                .NotEmpty();
            RuleFor(x => x.LastName)
                .NotNull()
                .Matches("^^[A-ZĄĆĘŁŃÓŚŹŻ][a-ząćęłńóśźż]*$")
                .NotEmpty();
            RuleFor(x => x.Age)
                .InclusiveBetween(0, 150)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.PlaceOfBirth)
                .NotNull()
                .NotEmpty()
                .Matches("^^[A-ZĄĆĘŁŃÓŚŹŻ][a-ząćęłńóśźż]*$");
        }
    }
}
