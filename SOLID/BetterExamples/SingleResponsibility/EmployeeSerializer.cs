using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace SOLID.BetterExamples.SingleResponsibility
{
    public class EmployeeSerializer
    {
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public string ToXml()
        {
            var serializer = new XmlSerializer(typeof(Employee));

            using (var stream = new MemoryStream())
            {
                serializer.Serialize(stream, this);
                return Encoding.UTF8.GetString(stream.ToArray());
            }
        }
    }
}
