using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesByStateGroup {
    class Program {

        static void Main(string[] args) {

            SalesByStateGroupLibrary.Class1 pgm = new SalesByStateGroupLibrary.Class1();

            var total = pgm.Get("IN") + pgm.Get("NY") + pgm.Get("MN");
            Console.WriteLine($"Sales for IN, NY, MN is {total}");

            total = pgm.Get("KY") + pgm.Get("PA") + pgm.Get("MI") + pgm.Get("IL");
            Console.WriteLine($"Sales for KY, PA, MI, IL is {total}");
        }
    }
}
