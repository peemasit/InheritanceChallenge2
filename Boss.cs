using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2 {
    class Boss:Emproyees {
        protected string CompanyCar { get; set; }

        public Boss(string firstName, string lastname, int salary,string companyCar) {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead() {
            Console.WriteLine($"i'm boss ! My name {FirstName} {LastName} ");
        }
    }
}
