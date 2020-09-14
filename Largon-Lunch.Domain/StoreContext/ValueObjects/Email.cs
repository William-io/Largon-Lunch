using FluentValidator;
using FluentValidator.Validation;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Largon_Lunch.Domain.StoreContext.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new ValidationContract()
                .Requires()
                .IsEmail(Address, "Email", "O E-mail é inválido")
                );
        }

        public string Address { get; set; }

        public override string ToString()
        {
            return Address;
        }
    }
}
