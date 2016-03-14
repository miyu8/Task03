using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleNS;

namespace SampleNS
{
    public static class CommonUtil
    {
        public static string ListToString(this IList<string> list)
        {
            StringBuilder result = new StringBuilder("");

            if (list.Count > 0)
            {
                result.Append(list[0].ToString());
                for (int i = 1; i < list.Count; i++)
                    result.AppendFormat(", {0}", list[i].ToString());
            }
            return result.ToString();
        }
    }
}
namespace MyList
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");
            Console.WriteLine(salmons.ListToString());
            Console.ReadKey();
        }
    }
}
