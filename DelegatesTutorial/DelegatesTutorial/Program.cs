using System;

namespace DelegatesTutorial {
    class Program {

        delegate void mathfunc();

        static void Main(string[] args) {

            mathfunc method;
            // set method to Print method
            mathfunc[] methods = { Print, Write };
            foreach(var m in methods) {
                m();
            }


        }
        static void Calc(int i) { }
        static void Write() {
            Console.WriteLine("Write");
        }
        static void Print() {
            Console.WriteLine("Print");
        }
    }
}
