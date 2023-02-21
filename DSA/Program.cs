using System;

namespace DSA
{
    class Program
    {
        public void calculateIterative(int n)
        {
            while (n > 0)
            {
                int k = n * n;
                Console.WriteLine(k);
                n = n - 1;
            }
        }
        static void Main(string[] args)
        {
            Program r = new Program();
            r.calculateIterative(4);
            Console.ReadKey();
        }
    }
}
