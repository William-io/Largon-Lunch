using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Largon_Lunch.Domain.StoreContext.ValueObjects
{
    public class Email
    {
        public Email(string address)
        {
            Address = address;
        }

        public string Address { get; set; }

        public override string ToString()
        {
            return Address;
        }
    }
}
