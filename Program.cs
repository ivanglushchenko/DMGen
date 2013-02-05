using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Product() { Name = "P1" };
            p1.AcceptChanges();

            var c1 = new Customer() { FirstName = "A", LastName = "B" };
            
            var o1 = new Order();
            o1.Products.Add(p1);
            c1.Orders.Add(o1);

            c1.AcceptChanges();
            c1.FirstName = "AA";
            c1.AcceptChanges();
            o1.Quantity = 10;
            c1.AcceptChanges();
        }
    }
}
