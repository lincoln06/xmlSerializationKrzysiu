using FluentValidation.Results;
using FunWithSerialization.Models;

namespace FunWithSerialization.View
{
    public class MessageOutput
    {
        public MessageOutput() { }

        public void WrongValue()
        {
            Console.WriteLine("Wprowadzona wartość jest nieprawidłowa. Spróbuj ponownie");
        }

        public void ShowMessage(IEnumerable<ValidationFailure> errorsList=null)
        {
            Console.WriteLine("Wprowadzono nieprawidłowe dane!\n\n");
            if (errorsList != null)
            {
                foreach (ValidationFailure failure in errorsList)
                {
                    Console.WriteLine(failure.ToString());
                }
            }
            Console.ReadKey();
        }

        public void ShowExceptionMessage(string message)
        {
            Console.ReadKey();
            Console.WriteLine(message);        
        }

        public void ShowSerializerSavedMessage(string xmlFilePath)
        {
            Console.WriteLine("Serializacja zakończona, plik został zapisany w: " + xmlFilePath);
            Console.ReadKey();
        }

        public void ShowDeserializerReadMessage()
        {
            Console.WriteLine("Deserializacja zakończona! Oto obiekt odczytany z pliku XML.");
        }

        public void ShowPerson(Person deserializedPerson)
        {
            Console.WriteLine($"Imię\t\t\t{deserializedPerson.FirstName}");
            Console.WriteLine($"Nazwisko\t\t{deserializedPerson.LastName}");
            Console.WriteLine($"Wiek\t\t\t{deserializedPerson.Age}");
            Console.WriteLine($"Miejsce urodzenia\t{deserializedPerson.PlaceOfBirth}");
            Console.ReadKey();
        }

        public void ShowXSDValidationErrors(List<string> errorsList)
        {
            Console.WriteLine("Plik XML nie jest zgodny ze schematem!\n\n");
            foreach (string error in errorsList) Console.WriteLine(error);
        }
    }
}
