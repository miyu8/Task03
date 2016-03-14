using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модуль
{
    class OverLoad
    {
        public int abs(int value)
        {
            if (value < 0)
            {
                value = -value;
            }
            return value;
        }
        public double abs(double value)
        {
            if (value < 0)
            {
                value = -value;
            }
            return value;
        }
        public long abs(long value)
        {
            if (value < 0)
            {
                value = -value;
            }
            return value;
        }
    }

class Program
    {
        static void Main(string[] args)
        {
            OverLoad over = new OverLoad();
            Console.WriteLine("" + over.abs(-1));
            Console.WriteLine("" + over.abs(-1.435));
            Console.WriteLine("" + over.abs(-9043523000));
            Console.ReadKey();
        }
    }
}
