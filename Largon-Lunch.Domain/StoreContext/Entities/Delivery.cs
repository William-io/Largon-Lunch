using System;

namespace Largon_Lunch.Domain.StoreContext.Entities

{
    public class Delivery
    {
        public Delivery(string status)
        {
            Status = status;
        }

        public DateTime CreateDate { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public string Status { get; set; }
    }
}