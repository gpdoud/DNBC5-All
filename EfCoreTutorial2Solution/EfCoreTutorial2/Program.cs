using EfCoreTutorial2.Models;
using System;
using System.Linq;

namespace EfCoreTutorial2 {
    class Program {

        static void Main(string[] args) {

            using(var db = new AppDbContext()) {

                #region Customer methods
                // similar to GetAllUsers
                var customers = db.Customers
                                    .Where(c => c.Active == true)
                                    .OrderBy(fred => fred.Name)
                                    .ToList();
                foreach(var customer in customers) {
                    //Console.WriteLine(customer.Name);
                }

                // similar to GetByPrimaryKey
                var id = 1;
                var pg = db.Customers.Find(id); // P&G
                //Console.WriteLine("PK:" + pg.Name);

                // similar to InsertUser
                var insCustomer = new Customer() {
                    Id = 0,
                    Name = "Kroger",
                    Active = true,
                    DateCreated = DateTime.Now
                };
                var hasKroger = db.Customers.Any(c => c.Name == "Kroger");
                if(!hasKroger) {
                    db.Customers.Add(insCustomer);
                }

                // similar to UpdateUser
                var cPG = db.Customers.Find(1);
                cPG.Name = "PG";

                // similar to DeleteUser
                var firstKroger = db.Customers.FirstOrDefault(c => c.Name == "Kroger");
                if(firstKroger != null) {
                    db.Customers.Remove(firstKroger);
                }
                #endregion
                #region Order methods
                var order1 = new Order() {
                    Date = DateTime.Now.AddDays(-7),
                    Description = "My first order a week ago",
                    CustomerId = db.Customers.SingleOrDefault(c => c.Name == "PG").Id,
                    Total = 1000
                };
                var order2 = new Order() {
                    Date = DateTime.Now,
                    Description = "My second order",
                    CustomerId = db.Customers.SingleOrDefault(c => c.Name == "Amazon").Id,
                    Total = 10000
                };
                var order3 = new Order() {
                    Date = DateTime.Now,
                    Description = "My third order",
                    CustomerId = db.Customers.SingleOrDefault(c => c.Name == "PG").Id,
                    Total = 5000
                };
                var order4 = new Order() {
                    Date = DateTime.Now,
                    Description = "My fourth order",
                    CustomerId = db.Customers.SingleOrDefault(c => c.Name == "Costco").Id,
                    Total = 7000
                };
                var order5 = new Order() {
                    Date = DateTime.Now,
                    Description = "My fifth order",
                    CustomerId = db.Customers.SingleOrDefault(c => c.Name == "PG").Id,
                    Total = 2000
                };
                //db.Orders.Add(order1);
                //db.Orders.Add(order2);
                //db.Orders.AddRange(new[] { order3, order4, order5 });

                #endregion

                db.SaveChanges();

                // read all orders

                var orders = db.Orders.ToList();
                //orders.ForEach(o => Console.WriteLine(o));

                var o1 = db.Orders.Find(1);
                //Console.WriteLine($"Find by PK: {o1}");

                // all orders > 5,000 sorted by total descending
                var oLt5kDesc = db.Orders
                                .Where(o => o.Total > 5000)
                                .OrderByDescending(o => o.Total)
                                .ToList();
                //oLt5kDesc.ForEach(o => Console.WriteLine(o));

                #region Order total for customer Costco

                var customerName = "Costco";
                var ordersTotal = db.Orders
                                    .Where(o => o.Customer.Name == customerName)
                                    .Sum(o => o.Total);
                Console.WriteLine($"Customer {customerName} total for orders is {ordersTotal:C}");

                #endregion

            }
        }
    }
}
