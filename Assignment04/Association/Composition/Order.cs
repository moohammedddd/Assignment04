using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.Association.Composition
{
    // Association RelationShip of Type Composition : if no Product  no OrderItem
    internal class Order
    {
        public int Id { get; set; }
        public required string UserEmail { get; set; }
        public decimal OrderTotal { get; set; }

        public required List<OrderItem> OrderItems { get; set; } // it is required (composition)

        // public  List<OrderItem>? OrderItems { get; set; } // it is optional 


    }
}
