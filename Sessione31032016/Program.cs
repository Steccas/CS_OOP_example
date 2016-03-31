using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sessione31032016
{
    class Program
    { 
        static String command = "";
        static int status = 9;
        static bool compareS(string s) { return command.Equals(s, StringComparison.OrdinalIgnoreCase); }

        static private Manager m;

        static void Main(string[] args) //con il metodo statico non ho bisogno di istanziare la classe (non posso istanziare il main)
        {
            System.Console.WriteLine("Benvenuto!");
            m = new Manager();
            for (;;)
            {
                System.Console.Write("> ");
                command = Console.ReadLine();
                if (compareS("set")) status = 1;
                if (compareS("get")) status = 2;
                if (compareS("exit")) status = 0;

                switch (status)
                {
                    case 1:
                        m.set();
                        status = 9;
                        break;
                    case 2:
                        m.print();
                        status = 9;
                        break;
                    case 0:
                        return;
                }
            }
        }
    }
}
