using FunWithSerialization.Models;
using FunWithSerialization.View;

namespace FunWithSerialization
{
    public class App
    {
        private readonly DataReceiver _dataReceiver=new DataReceiver();
        private readonly MessageOutput _output=new MessageOutput();
        private readonly Serializer _serializer = new Serializer();
        private readonly Deserializer _deserializer = new Deserializer();
        public void Run()
        {
            Person person=_dataReceiver.GetPersonDataFromUser();

            if (person is null) {
                _output.ShowMessage();
                return;
            }

            _serializer.Serialize(person);

            Person deserializedPerson = _deserializer.Deserialize();
            _output.ShowPerson(deserializedPerson);
            
        }
    }
}
