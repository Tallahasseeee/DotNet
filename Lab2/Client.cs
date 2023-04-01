using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2DotNet
{
    public class Client
    {
        public string Name;
        public string Address;
        public string PhoneNumber;

        public Client() { }
        public Client(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
