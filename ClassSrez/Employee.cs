using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSrez
{
    class Employee
    {
        public string SurName { get; set; }
        public double Sullary { get; set; }

        public DateTime YearOfStart { get; set; }
        public string Position { get; set; }

        public Employee()
        {

        }
        public Employee(string SurName, double Sullary, DateTime YearOfStart, string Position)
        {
            this.SurName = SurName;
            this.Sullary = Sullary;
            this.YearOfStart = YearOfStart;
            this.Position = Position;
        }

        public Employee(string SurName, double Sullary,  DateTime YearOfStart)
        {
            this.SurName = SurName;
            this.Sullary = Sullary;
            this.YearOfStart = YearOfStart;
        }
        ~Employee()
        {
            Console.WriteLine("Deleted");
        }

        public override string ToString()
        {
            return SurName + "\n" + Sullary + "\n" + YearOfStart + "\n" + Position +"\n";
        }

        public TimeSpan f()
        {
            DateTime localDate = DateTime.Now;
            return localDate - YearOfStart;
        }

        public int f2()
        {
            DateTime localDate = DateTime.Now;
            TimeSpan res = localDate - YearOfStart;
            return res.Days;
        }
    }

    class EmployeesList
    {
        public List<Employee> employees;
        public EmployeesList()
        {

        }
        public EmployeesList(List<Employee> employees)
        {
            this.employees = employees;
        }

        ~EmployeesList()
        {
            Console.WriteLine("Deleted");
        }

        public void f()
        {
            foreach (Employee i in employees)
            {
                double res = i.Sullary * 0.15;
                i.Sullary += res;
            }
        }
        public void PrintLis()
        {
            foreach(Employee i in employees)
            {
                Console.WriteLine(i);
            }
        }
        public void f2()
        {
            foreach(Employee i in employees)
            {
                if (i.SurName.Contains("Ivan"))
                {
                    i.Position = "Inzener";
                }
            }
        }
    }
}
