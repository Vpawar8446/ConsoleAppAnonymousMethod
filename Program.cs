using System;

namespace ConsoleAppAnonymousMethod
{ 
    class Program
    {
        public delegate void DelegateSquare(int n);

        static void Main(string[] args)
        {
            DelegateSquare ds = delegate (int x)
            {
                Console.WriteLine(x * x);
            };

            ds(4);

        }
    }
}
