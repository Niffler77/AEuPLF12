using System.Xml.Serialization;

namespace Dateneinlesen
{
    [XmlRoot("catalog")]
    public class catalog
    {
        [XmlElement("song")]
        public Song[] songs { get; set; }
    }
    public class Song
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }  

        [XmlElement("artist")]
        public string Artist { get; set; }

        [XmlElement("country")]
        public string Country { get; set; }

        [XmlElement("company")]
        public string Company { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("year")]
        public int Year { get; set; }
    }
}
