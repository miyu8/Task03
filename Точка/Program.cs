using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Точка
{
    class Class
    {
        public int x, y, z;
        public Class() { x = y = z = 0; }
        public Class(int x, int y, int z) { this.x = x; this.y = y; this.z = z; }

        public static Class operator +(Class ob1, Class ob2)
        {
            Class t = new Class();
            t.x = ob1.x + ob2.x;
            t.y = ob1.y + ob2.y;
            t.z = ob1.z + ob2.z;
            return t;
        }
        public static Class operator -(Class ob1, Class ob2)
        {
            Class t = new Class();
            t.x = ob1.x - ob2.x;
            t.y = ob1.y - ob2.y;
            t.z = ob1.z - ob2.z;
            return t;
        }

        public void Show()
        {
            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class ob1 = new Class(1, 2, 3);
            Class ob2 = new Class(5, 5, 5);
            Class ob3 = new Class();
            Class ob4 = new Class();
            ob3 = ob1 + ob2;
            ob4 = ob1 - ob2;
            ob3.Show();
            ob4.Show();
            Console.ReadKey();
        }
    }
}
