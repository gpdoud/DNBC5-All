using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMath {
    class Program {
        static void Main(string[] args) {
            var x = int.MaxValue;
            checked {
                x++;
            }
        }
    }
}
