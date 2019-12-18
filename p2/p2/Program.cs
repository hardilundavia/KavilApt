using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Area
    {
        double a = new double();
        const double pi = 3.14;
        public void area(double r)
        {
            a = pi * (r * r);
            Console.WriteLine("Area of Circle is : {0}  ",a);
        }
        public void area(double l,double w)
        {
            a = l * w;
            Console.WriteLine("Area of Ractangle is : {0}  ", a);
        }
        public void area(double s,int e)
        {
            a = s * s;
            Console.WriteLine("Area of Square is : {0}  ", a);
        }
        public void area(double b,double h, int e)
        {
            a =(b * h) / 2;
            Console.WriteLine("Area of Triangle is : {0}  ", a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            double r,l,w,s,b,h = new double();
            Area a = new Area();
            Console.WriteLine("\nArea of Circle \n");
            Console.WriteLine("Enter The Value of R : ");
            r = Convert.ToDouble(Console.ReadLine());
            a.area(r);

            Console.WriteLine("\nArea of Ractangle \n");
            Console.WriteLine("Enter The Value of L : ");
            l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Value of W : ");
            w = Convert.ToDouble(Console.ReadLine());
            a.area(l, w);

            Console.WriteLine("\nArea of Square \n");
            Console.WriteLine("Enter The Value of s : ");
            s = Convert.ToDouble(Console.ReadLine());
            a.area(s, 0);

            Console.WriteLine("\nArea of Triangle \n");
            Console.WriteLine("Enter The Value of B : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Value of H : ");
            h = Convert.ToDouble(Console.ReadLine());
            a.area(b,h,0);
        }
    }
}
