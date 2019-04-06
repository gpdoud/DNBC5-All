using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpToSql;

namespace TestPrsLibrary {
    class Program {
        static void Main(string[] args) {

            //var greg = new User(0, "gdoud", "MAX", "Greg", "Doud", "513-555-1212", "gdoud@maxtrain.com", true, true);
            //var success = User.InsertUser(greg);
            //if(!success) {
            //    Console.WriteLine("Insert failed");
            //}
            var users = User.GetAllUsers();
            foreach(var user in users) {
                if(user == null) {
                    continue;
                }
                Console.WriteLine(user);
            }

        }
    }
}
