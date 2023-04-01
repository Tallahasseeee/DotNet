using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DotNet
{
    [XmlRoot("Agency")]
    public class Agency
    {
        [XmlElement("AutoPark")]
        public List<Auto> AutoPark = new List<Auto>();

        [XmlElement("Clients")]
        public List<Client> Clients = new List<Client>();

        [XmlElement("Deals")]
        public List<Deal> Deals = new List<Deal>();
    }
}
