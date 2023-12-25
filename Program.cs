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

            Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos.
            Fórmula da área: area = π . raio2
            Considere o valor de π = 3.14159
           
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
