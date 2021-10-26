using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] sal;
            Console.WriteLine("Enter Employee count: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            sal = new int[n];
           
            for (int i = 0; i < n; i++)
            {
                sal[i] = Convert.ToInt32(Console.ReadLine());

            }
            int maxSal = sal.Max();
            Console.WriteLine("maximum salary of emploee : " + maxSal);

            int minSal = sal.Min();
            Console.WriteLine("minium salary of employye: " + minSal);

            int avgSal = Convert.ToInt32(sal.Average());
            Console.WriteLine("average salary of employee : " + avgSal);



        }
    }
}

