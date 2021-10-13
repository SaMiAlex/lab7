using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба, см");
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;


            GetParam(a, out S, out V);

            Console.WriteLine("Площадь поверхности куба S={0} см2, объем куба V={1} см3", S, V);
            
            Console.ReadKey();
        }

        static void GetParam(int a, out double S, out double V)
        {
            S = ((double)a*a*6);
            V = a * a * a;
        }

    }
}
