using System;
using System.Collections.Generic;
using System.Text;

namespace Largon_Lunch.Domain.StoreContext.ValueObjects
{
    public class Document
    {
        public Document(string number)
        {
            Number = number;
        }
        public string Number { get; set; }

        public override string ToString()
        {
            return Number;
        }
    }

    
}
