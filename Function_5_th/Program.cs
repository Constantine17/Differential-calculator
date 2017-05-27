using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_5_th
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");
            var c = new constanta(1);
            double number = 5;
            var x = new Arg();
            //var y = new Arg("y");
            var sinx = new sin(x);
            var cosx = new cos(x);
            var tanx = new tan(x);
            var ctanx = new ctan(x);
            var addxc = new add(x, c);
            var subxc = new sub(x, c);
            var mulxc = new mul(x, c);
            var divxc = new div(x, c);
            Console.WriteLine("-----------------------------------------------------------");
            Function arg = divxc;
            Console.WriteLine("ToString ={0}", arg.ToString());
            Console.WriteLine("Culc ={0}", arg.Culc(number));
            Console.WriteLine("diff string ={0}", arg.Diff().ToString());
            Console.WriteLine("diff culc ={0}", arg.Diff().Culc(number));
            Console.ReadKey();

        }
    }
}
