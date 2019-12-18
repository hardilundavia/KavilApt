using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Number Do you want to enter : ");
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            String[] s1 = new string[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter A String : ",i);
                s1[i] = Console.ReadLine();
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("String is : {0} ",s1[i]);
            }
            int count = 0;
            for(int i=0;i<n;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if (s1[i] == s1[j])
                        count++;
                }
            }
            Console.WriteLine("\nTotal {0} ",count+" is Same.");
        }
    }
}
