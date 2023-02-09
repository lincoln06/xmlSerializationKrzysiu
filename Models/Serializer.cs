using FunWithSerialization.View;
using System.Xml.Serialization;

namespace FunWithSerialization.Models
{
    public class Serializer:BaseSerializer
    {
        private readonly MessageOutput _output=new MessageOutput();
        public Serializer():base()
        {

        }
        public void Serialize(Person person)
        {
            
            using (var reader = File.OpenWrite(xmlFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(reader, person);
            }
            _output.ShowSerializerSavedMessage(xmlFilePath);
        }
    }
}
