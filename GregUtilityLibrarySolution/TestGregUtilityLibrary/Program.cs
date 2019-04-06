using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GregUtilityLibrary;

namespace TestGregUtilityLibrary {

    class Program {

        static void Main(string[] args) {
            
            string[] zips = { "12345", "123456789", "12345-6789", "1234-56789" };
         
            foreach(var zip in zips) {
                Console.WriteLine($"{zip} is " + (Strings.ValidUSZipCode(zip) ? "" : " not ") + "valid");
            }

            var phone1 = "322-8888";
            var phone1Valid = Strings.ValidUSPhoneNumber(phone1);
            if(phone1Valid) {
                Console.WriteLine($"{phone1} is valid");
            } else {
                Console.WriteLine($"{phone1} is not valid");
            }
            var phone2 = "513-322-8888";
            var phone2Valid = Strings.ValidUSPhoneNumber(phone2);
            if(phone1Valid) {
                Console.WriteLine($"{phone2} is valid");
            } else {
                Console.WriteLine($"{phone2} is not valid");
            }

            var result = Strings.EqualIgnoreCase("ABC", "abc ");
            if(result == true) {
                Console.WriteLine("Equal");
            } else {
                Console.WriteLine("Not Equal");
            }
            Console.ReadKey();
        }
    }
}
