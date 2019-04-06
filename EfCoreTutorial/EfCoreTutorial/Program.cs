using System;
using System.Linq;

namespace EfCoreTutorial {
    class Program {
        static void Main(string[] args) {

            using(var db = new AppDbContext()) {
                var c = new Customer();
                c.Name = "Test Customer";
                db.Customers.Add(c);
                db.SaveChanges();
                var customers = db.Customers.OrderBy(c1 => c1.Name).ToList();
            }
        }
    }
}
