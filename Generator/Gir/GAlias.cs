using System.Xml.Serialization;

namespace Gir
{
    public class GAlias
    {
        [XmlAttribute("name")]
        public string? Name { get; set; }

        [XmlAttribute("type", Namespace="http://www.gtk.org/introspection/c/1.0")]
        public string? Type { get; set; }

        [XmlElement("doc")]
        public GDoc? Doc { get; set; }

        [XmlElement("type")]
        public GType? For { get; set; }
    }
}
