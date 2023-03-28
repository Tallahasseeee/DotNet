using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1DotNet
{
    class Deal
    {
        public Client Client;
        public Auto Auto;
        public DateTime DateOfIssue;
        public DateTime DateOfReturn;

        public Deal(Client client, Auto auto, DateTime dateOfIssue, DateTime dateOfReturn)
        {
            Client = client;
            Auto = auto;
            DateOfIssue = dateOfIssue;
            DateOfReturn = dateOfReturn;
        }
    }
}
