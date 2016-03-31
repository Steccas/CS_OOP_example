using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessione31032016
{
    public class Manager
    {
        protected day d;
        public Manager() { d = new day(); }

        public void print()
        {
            System.Console.WriteLine(d.day + "/" + d.month + "/" + d.year);
            System.Console.WriteLine(d.h + ":" + d.m);
        }

        public void set()
        {
            System.Console.WriteLine("Insert day: ");
            d.day = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Insert month: ");
            d.month = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Insert year: ");
            d.year = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Insert hours: ");
            d.h = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Insert minutes: ");
            d.m = Convert.ToInt32(Console.ReadLine());
        }
    }
}
