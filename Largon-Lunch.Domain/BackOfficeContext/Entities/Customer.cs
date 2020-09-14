using Largon_Lunch.Domain.StoreContext.Entities;
using Largon_Lunch.Domain.StoreContext.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Largon_Lunch.Domain.BackOfficeContext.Entities
{
    public class Customer
    {
        public IReadOnlyCollection<Product> Products { get; set; }
        public Name Name{ get; set; }
    }
}
