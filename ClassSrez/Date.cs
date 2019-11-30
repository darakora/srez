using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSrez
{
    class Date
    {
        private int day;
        public int Day
        {
            get { return day; }
            set
            {
                if (value < 32 && value > 0)
                {
                    day = value;
                }
                else
                {
                    day = 1;
                }

            }
        }

        private int mounth;
        public int Mounth
        {
            get { return mounth; }
            set
            {
                if (value < 13 && value > 0)
                {
                    mounth = value;
                }
                else
                {
                    mounth = 1;
                }
            }
        }

        private int year;
        public int Year { get; set; }

        public Date()
        {

        }
        public Date(int day, int mounth, int year)
        {
            this.Day = day;
            this.Mounth = mounth;
            this.Year = year;
        }

        ~Date()
        {
            Console.WriteLine("Deleted");
        }

        public bool f()
        {
            return year % 4 == 0;
        }

        public override string ToString()
        {
            return Day + "\n" + Mounth + "\n" + Year + "\n";
        }

        public void f2()
        {
            this.day += 5;
            if(day > 32)
            {
                this.mounth += 1;
                if(this.mounth > 12)
                {
                    this.year += 1;
                }
            }
        }

    }
}
