using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassProject {
    class Student {
        public string Prefix { get; private set; }
        public string FirstName { get; set; }
        public string LastName;
        private string _phone;
        public string Phone {
            get {
                return _phone;
            }
            set {
                if(value.Length < 7 || value.Length > 10)
                    Console.WriteLine("Error");
                else {
                    _phone = value;
                }
            }
        }
        public string Email;
        private double _GPA;
        public double GPA {
            get {
                return _GPA;
            }
            set {
                _GPA = value;
            }
        }
        public int SAT { get; set; }

        public Student(string fname, string lname, string phone, 
                        string email, double gpa, int sat) {
            FirstName = fname;
            LastName = lname;
            Phone = phone;
            Email = email;
            GPA = gpa;
            SAT = sat;
        }
        public Student(string fname, string lname, double gpa) {
            FirstName = fname;
            LastName = lname;
            Phone = "513-555-1212";
            Email = "me@gmail.com";
            GPA = gpa;
            SAT = 1000;
        }
        public Student() {

        }

        public string FullName() {
            return $"{FirstName} {LastName}";
        }
        public string Print() {
            return $"{FirstName} {LastName}|{Phone}|{Email}|{GPA}|{SAT}";
        }
        public string Print(string message) {
            return $"{message} :: " + Print();
        }
        public string Print2() {
            return FullName() + $"|{Phone}|{Email}|{GPA}|{SAT}";
        }
    }
}
