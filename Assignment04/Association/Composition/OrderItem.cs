using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.Association.Composition
{
    // Association RelationShip of Type Composition : if no Product  no OrderItem
    internal class OrderItem
    {
        public int Id { get; set; }
        public required Product Product { get; set; }

        //public OrderItem(Product product)
        //{
        //    Product = product;
        //}
        //public OrderItem(int _id , Product product)
        //{

        //    Id = _id ;
        //    Product = product ;
        //}
    }
}
