using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
public class Program
{
    public static void Main()
    {
        int n, i, sum;
        int n1, n2;

        Console.Write("n1 = ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("n2 = ");
        n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Perfect numbers within the given range : ");
        for (n = n1; n <= n2; n++)
        {
            i = 1;
            sum = 0;
            while (i < n)
            {
                if (n % i == 0)
                    sum = sum + i;
                i++;
            }
            if (sum == n)
                Console.WriteLine("\t" + "{0} ", n);
        }
        Console.Write("\n");
        Console.ReadLine();
    }
}