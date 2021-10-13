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
            Console.WriteLine("Введите стороны первого треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double s1, s2, p1, p2;


            GetParam(a1, b1, c1, a2, b2, c2, out s1, out s2, out p1, out p2);
     
            if (s1>s2)
            {
                Console.WriteLine("Площадь первого треугольника S1={0} больше площади второго трегольника S2={1}",s1,s2);
            }
            else
            {
                Console.WriteLine("Площадь первого треугольника S1={0} меньше площади второго трегольника S2={1}", s1, s2);
            }
            Console.ReadKey();
        }

        static void GetParam(int a1, int b1, int c1, int a2, int b2, int c2, out double p1, out double p2, out double s1, out double s2)
        {
            p1 = ((double)a1 + b1 + c1) / 2;
            p2 = ((double)a2 + b2 + c2) / 2;
            s1 = Math.Sqrt((double)p1 * (p1 - a1) * (p1 - b1) * (p1 - c1));
            s2 = Math.Sqrt((double)p2 * (p2 - a2) * (p2 - b2) * (p2 - c2));            
        }

    }
}
