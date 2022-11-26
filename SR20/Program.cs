using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {

            MyDelegate myDelegate = CircleLenght;
            double r = myDelegate(2);
            Console.WriteLine(r);

            myDelegate = CircleSquare;
            r = myDelegate(2);
            Console.WriteLine(r);

            myDelegate = SphereVolume;
            r = myDelegate(2);
            Console.WriteLine(r);

            Console.ReadKey();
        }
        static double CircleLenght(double r) => 2*Math.PI*r;
        static double CircleSquare(double r) =>  Math.PI * r*r;
        static double SphereVolume(double r) =>  4.0/3*Math.PI * r*r*r;
    }
}
