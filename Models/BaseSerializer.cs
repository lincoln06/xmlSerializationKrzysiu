using System.Xml.Serialization;

namespace FunWithSerialization.Models
{
    public abstract class BaseSerializer
    {
        protected string xmlFilePath = @"Data\Person.xml";
        protected string xsdFilePath = @"Data\Person.xsd";
        public BaseSerializer()
        {
            
        }
    }
}
