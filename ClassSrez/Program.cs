using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSrez
{
    class Program
    {
        class Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public int z { get; set; }
            public Point()
            {

            }
            public Point(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            ~Point()
            {
                Console.WriteLine("deleted");
            }

            public override string ToString()
            {
                return x + "\n" + y + "\n" + z + "\n";
            }
            public double f()
            {
                return Math.Pow((x * y * z), 1 / 3);
            }

            public int f2()
            {
                int temp = x + y + z;
                int count = 0;
                for( ; temp != 0; temp /= 10)
                {
                    ++count;
                }
                return count;
            }
            
        }
        public static int fp(int a, int b, int c, int d)
        {
            return Math.Max(Math.Max(a, b), Math.Max(c, d));
        }


        static void Main(string[] args)
        {
            /*Point p = new Point(1, 2, 1);
            double res = p.f();
            Console.WriteLine(res);
            Console.WriteLine(p.f2());
            Console.WriteLine(p.ToString());
            Employee employee = new Employee("Lala", 100.5, new DateTime(2019, 11, 25));
            Console.WriteLine(employee.f2());
            Console.WriteLine(employee.ToString());
            Console.WriteLine("----------------------------------");
            List<Employee> e = new List<Employee>()
            {
                new Employee("Ivan", 20.5, new DateTime(2003, 11, 22), "koksojkd"),
                new Employee("KOOO", 20.5, new DateTime(2003, 11, 22), "koksojkd")
            };

            EmployeesList employees = new EmployeesList(e);
            employees.f2();
            employees.PrintLis();
            */

            Date date = new Date(2016, 11, 29);
            date.f2();
            Console.WriteLine(date.ToString());
            Console.WriteLine(fp(1, 2, 3, 6));
            
            Console.ReadKey();
        }
    }
}
