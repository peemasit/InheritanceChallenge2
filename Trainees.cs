using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceChallenge2 {
    class Trainees:Emproyees {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }
        
        public Trainees(string firstName, string lastname, int salary, int workingHours, int schoolHours) {
            this.FirstName = firstName;
            this.LastName = lastname;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }
        
        public void Learn() {
            Console.WriteLine($"i'm learning for {SchoolHours} hours!");
        }

        public void Work() {
            Console.WriteLine($"i'm working for {WorkingHours} hours!");
        }
    }
}
