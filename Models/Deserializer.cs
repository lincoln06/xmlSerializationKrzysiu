using FunWithSerialization.Models.Validation;
using FunWithSerialization.View;
using System.Xml.Serialization;

namespace FunWithSerialization.Models
{
    public class Deserializer:BaseSerializer
    {
        private readonly MessageOutput _output=new MessageOutput();
        private readonly XMLValidator _xmlValidator=new XMLValidator();
        public Deserializer():base(){

        }
        public Person? Deserialize()
        {
            List<string> errorsList = _xmlValidator.Validate(xmlFilePath,xsdFilePath);
            if (errorsList.Count != 0)
            {

                _output.ShowXSDValidationErrors(errorsList);
                return null;
            }
            Person person = null;
            using (var reader = File.OpenRead(xmlFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                person = (Person)serializer.Deserialize(reader);
            }
            _output.ShowDeserializerReadMessage();
            return person;
        }
    }
}
