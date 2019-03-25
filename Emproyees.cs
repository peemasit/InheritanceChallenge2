using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2 {
    class Emproyees {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Salary { get; set; }

        public Emproyees() {
        }

        public Emproyees(string firstName,string lastname,int salary) {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Salary = salary;
        }
        

        public void Work() {
            Console.WriteLine("i'm working");
        }
        public void Pause() {
            Console.WriteLine("i'm having a break");
        }


}
}
