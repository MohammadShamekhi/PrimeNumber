using System;

namespace Prime_factorizations
{
    class Program
    {
        static bool Check_Prime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for(int i = 2; i <= (int)Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        static void Main()
        {
            int n;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please input the integer!Enter again:");
                    continue;
                }
                if (n <= 0)
                {
                    Console.WriteLine("Please input positive number!Enter again:");
                    continue;
                }
                break;
            }
            for(int i = 1; i <= n; i++)
            {
                if (Check_Prime(i))
                {
                    int tedad = 0;
                    while (true)
                    {
                        if (n % i == 0)
                        {
                            tedad++;
                            n = n / i;
                        }
                        else
                        {
                            if (tedad > 0)
                            {
                                Console.WriteLine(i + "  " + tedad);
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
