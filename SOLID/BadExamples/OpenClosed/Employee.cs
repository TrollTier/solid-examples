using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace SOLID.BadExamples.OpenClosed
{
    public class Employee
    {
        public Guid Id { get; set; }
        public int PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

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
