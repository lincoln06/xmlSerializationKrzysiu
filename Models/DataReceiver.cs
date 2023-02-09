using FluentValidation.Results;
using FunWithSerialization.Models.Validation;
using FunWithSerialization.View;

namespace FunWithSerialization.Models
{
    public class DataReceiver
    {
        private readonly PersonValidator _validator=new PersonValidator();
        private readonly MessageOutput _output = new MessageOutput();
        public Person? GetPersonDataFromUser()
        {
            try
            {
                Console.WriteLine("Enter first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter last name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                int age = GetIntFromUser();
                Console.WriteLine("Enter place of birth");
                string placeOfBirth = Console.ReadLine();

                Person person = new Person { FirstName = firstName, LastName = lastName, Age = age, PlaceOfBirth = placeOfBirth };
                List<ValidationFailure> errorsList = _validator.Validate(person).Errors;
                if (errorsList.Count == 0) return person;
                _output.ShowMessage(errorsList);
                return null;
            }
            catch (Exception ex)
            {
                _output.ShowExceptionMessage(ex.Message);
                return null;
            }
        }
        private int GetIntFromUser()
        {
            int value = 0;
            bool isAbleToParse = false;
            while (isAbleToParse == false)
            {
                isAbleToParse = int.TryParse(Console.ReadLine(), out value);
                if (!isAbleToParse) _output.WrongValue();
            }
            return value;
        }
    }
}
