using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_Parabola
    {
        [XmlElement(ElementName = "focal")]
        public float Focal;

        [XmlElement(ElementName = "extra")]
        public Grendgine_Collada_Extra[] Extra;
    }
}

