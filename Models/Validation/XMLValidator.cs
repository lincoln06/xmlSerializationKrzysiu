using System.Xml.Schema;
using System.Xml;

namespace FunWithSerialization.Models.Validation
{
    public class XMLValidator:BaseSerializer
    {
        public List<string> _listOfErrors = new List<string>();

        public bool CheckDataCorrection(string arg1, string arg2, string arg3, string arg4)
        {
            if (arg1 == String.Empty || arg2 == String.Empty || arg3 == String.Empty || arg4 == String.Empty)
                return false;
            return true;
        }

        public List<string> Validate(string xmlFilePath, string xsdFilePath)
        {
            XmlReaderSettings settings = new();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add("", xsdFilePath);
            XmlReader reader = XmlReader.Create(xmlFilePath, settings);
            while (reader.Read())
            {

            }
            return _listOfErrors;
        }

    }
}
