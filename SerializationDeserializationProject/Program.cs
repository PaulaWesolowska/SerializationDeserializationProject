using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationDeserializationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Paula";
            person.LastName = "Wesolowska";
            person.Index = 56694;
            person.SaveFile("PersonalData.xml");
            Person load = Person.LoadFile("PersonalData.xml");
        }
    }
}
