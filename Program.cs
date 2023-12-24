using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDiferenca
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d, df;
            
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            Console.WriteLine( );

            df= (a*b-c*d);
            Console.WriteLine("df = "+ df);

            Console.ReadLine();





        }
    }
}
