using System.Xml.Serialization;

namespace Serialization_deserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //soap serialization is absolete , so we use XML serializer instead of soap serializer

            Student s = new Student { id = 101, name = "john"};

            //create a file stream
            FileStream fs = new FileStream("student.xml",FileMode.Create);

            //use xmlSerializer instead of soapformatter
            XmlSerializer serializer = new XmlSerializer(typeof(Student));

            //serialize object to XML format
            serializer.Serialize(fs, s);
            fs.Close();
        }
    }
}
