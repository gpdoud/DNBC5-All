using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNBC5_Assignments {
    class Program {

        #region Sum numbers using for()
        static void UseForToSumNumber() {
            var total = 0;
            for(var idx = 0; idx < 10; idx++) {
                total = total + idx;
            }
            Console.WriteLine($"Total is {total}");
        }
        #endregion

        #region Sum numbers from 1 to 100
        static void SumNumbers1To100() {
            var total = 0;
            var counter = 1;
            while(counter <= 100) {
                total = total + counter;
                counter = counter + 1;
            }
            Console.WriteLine($"The sum of the numbers 1 to 100 is {total}");
        }
        #endregion

        #region Multiply numbers up to 25
        static void MultiplyNumbers1to25() {
            var total = 1;
            var counter = 1;
            while(counter <= 25) {
                total = total * counter;
                counter = counter + 1;
            }
            Console.WriteLine($"Multiplying the numbers 1 to 25 totals {total}");
        }
        #endregion

        static void Main(string[] args) {
            //UseForToSumNumber();
            //SumNumbers1To100();
            //MultiplyNumbers1to25();
        }
    }
}
