using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVsInstance {
    class Person {

        public string Name = "MAX Technical Training";
        private static string Author = "Greg Doud";

        public static void Copyright() {
            var name = GetName();
            Console.WriteLine($"Copyright (c) 2019 by {Author} All rights reserved.");
        }
        private static string GetName() {
            return Name;
        }

    }

    class Program {
        static void Main(string[] args) {
        }
    }
}
