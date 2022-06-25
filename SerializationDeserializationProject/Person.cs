using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationDeserializationProject
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Index { get; set; }


        public void SaveFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(stream, this);
            }
        }
        public static Person LoadFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var deserializer = new XmlSerializer(typeof(Person));
                return (Person)deserializer.Deserialize(stream);
            }
        }
    }
}
