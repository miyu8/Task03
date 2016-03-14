using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Металл
{
    class Program
    {
        static void Main(string[] args)
        {
            string Me = "Когда металлическая руда является ионным соединением металла и неметалла, для извлечения чистого металла она обычно подвергается выплавлению — нагреву с восстановителем." +
                "Многие распространенные металлы, такие, как железо, плавят с использованием в качестве восстановителя углерода." +
                "Некоторые металлы, такие как алюминий и натрий, не имеют ни одного экономически оправданного восстановителя и извлекаются с применением электролиза.";
           MatchCollection match = Regex.Matches(Me, "[а-я]*[м]еталл[а-я]*", RegexOptions.IgnoreCase);
           Console.WriteLine("Исходная строка:\n\n{0}\n\n\nВидоизмененная строка:\n", Me);
           foreach (Match m in match)
                Console.WriteLine(m);
           Console.ReadKey();
        }
    }
}
