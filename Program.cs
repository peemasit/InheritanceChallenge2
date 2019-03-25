using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a main class with a Main Method, then a base class Employee with the properties Name, FirstName, Salary 
//and the methods Work() and Pause().
//Create a deriving class boss with the propertie CompanyCar and the method Lead().
//Create another deriving class of employees - trainees with the properties WorkingHours and SchoolHourse and a method Learn().
//Override the methods Work() of the trainee class so that it indicates the working hours of the trainee.
//Don’t forget to create the constructors.
//Create an object of each of the three classes (with arbitrary values)
//and call the methods, Lead() of Boss and Work() of Trainee.
//Just print out the respective text, what the respective employees do.

namespace InheritanceChallenge2 {
    class Program {
        static void Main(string[] args) {
            Emproyees Jim = new Emproyees("Jim", "Miller", 4000);
            Jim.Work();
            Jim.Pause();
            Boss John = new Boss("John", "Sena", 10000, "Ferrari");
            John.Lead();
            Trainees Jack = new Trainees("Jack", "Cook", 2000, 32, 8);
            Jack.Learn();
            Jack.Work();
            Console.ReadLine();
        }
    }
}
