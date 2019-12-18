using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3
{
    class Program
    {
        public void getMinMax(int[] arr,int n)
        {
            Array.Sort(arr);
            Console.WriteLine("Minimum Value : {0} ", arr[0]);
            Console.WriteLine("Maximum Value : {0} ", arr[n-1]);

        }
        static void Main(string[] args)
        {
            int n = new int();
            Console.WriteLine("How many Number Do You want to enter : ");
            n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter Number [{0}] : ",i);
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            Program p1 = new Program();
            p1.getMinMax(arr,n);
        }
    }
}
