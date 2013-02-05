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
            var c1 = new Customer() { FirstName = "A", LastName = "B" };
            var p1 = new Product() { Name = "P1" };
            var o1 = new Order();
            o1.Products.Add(p1);
            c1.Orders.Add(o1);

            c1.AcceptChanges();
        }
    }
}
