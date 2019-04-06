using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticProject {

    public class Arithmetic {

        // Range for Add, Subtract, Multiply, Divide
        // is -50 < x < 50
        public static int Add(int op1, int op2) {
            CheckRange(op1, op2);
            return op1 + op2;
        }

        public static int Subtract(int op1, int op2) {
            CheckRange(op1, op2);
            return op1 - op2;
        }

        public static int Multiply(int op1, int op2) {
            CheckRange(op1, op2);
            return op1 * op2;
        }

        public static int Divide(int op1, int op2) {
            CheckRange(op1, op2);
            try {
                var value = op1 / op2;
                return value;
            } catch(DivideByZeroException) {
                throw new Exception("Cannot divide by zreo");
            }
        }
        private static void CheckRange(int op1, int op2) {
            if(op1 <= -50 || op1 >= 50 || op2 <= -50 || op2 >= 50) {
                throw new Exception("Range must be -50 < x < 50");
            }
        }

        public static int sqr(int nbr) {
            if(nbr < 10 || nbr > 100) {
                throw new Exception("Nbr out of range");
            }
            return nbr * nbr;
        }
    }
}
