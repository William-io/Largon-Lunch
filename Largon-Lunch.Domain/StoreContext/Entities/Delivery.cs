using Largon_Lunch.Domain.StoreContext.Enums;
using System;

namespace Largon_Lunch.Domain.StoreContext.Entities

{
    public class Delivery
    {
        public Delivery(DateTime estimatedDeliveryDate)
        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;
        }

        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }

        public void Ship() //Enviar pedido
        {
            Status = EDeliveryStatus.Shipped;
        }

        public void Cancel()
        {
            //Se o status já estiver entregue não pode cancelar
            Status = EDeliveryStatus.Canceled;
        }
    }
}