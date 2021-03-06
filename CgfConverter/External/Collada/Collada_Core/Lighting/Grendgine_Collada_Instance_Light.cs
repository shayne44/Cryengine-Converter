using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_Instance_Light
    {
        [XmlAttribute("sid")]
        public string sID;

        [XmlAttribute("name")]
        public string Name;

        [XmlAttribute("url")]
        public string URL;


        [XmlElement(ElementName = "extra")]
        public Grendgine_Collada_Extra[] Extra;
    }
}

