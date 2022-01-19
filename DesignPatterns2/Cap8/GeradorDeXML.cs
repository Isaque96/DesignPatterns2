using System.Xml.Serialization;

namespace DesignPatterns2.Cap8
{
    public class GeradorDeXML
    {
        public string GeraXML(object o)
        {

            XmlSerializer serializer = new(o.GetType());
            StringWriter writer = new();

            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
