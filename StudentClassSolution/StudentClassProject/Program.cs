using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProject {
    class Program {
        static void Main(string[] args) {
            var chris = new Student();
            var ken = new Student();
            var kellan = new Student();
            var irena = new Student();
            var ben = new Student();
            var sammy = new Student();
            var seth = new Student("Seth", "Phillips", "555-555-2323", "info@seth.com",  3.7, 1400);

            Console.WriteLine(seth.Print());
            seth.Phone = "1234567890";
            Console.WriteLine(seth.Print("Changed Seth's Phone"));

            chris.FirstName = "Chris";
            chris.LastName = "Caudill";
            chris.GPA = 3.5;
            chris.SAT = 1250;
            chris.Phone = "513-555-1212";
            Console.WriteLine( chris.Print() );
            Console.WriteLine(chris.Print2());

            ken.FirstName = "Ken";
            ken.LastName = "Doud";
            ken.GPA = 3.0;
            ken.SAT = 1100;
            ken.Phone = "513-555-1212";
            Console.WriteLine(ken.Print());
            Console.ReadKey();
        }
    }
}
