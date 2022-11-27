using System;

namespace lab1ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            //instructiunea switch
            Console.WriteLine("Introduceti un numar intreg: ");
            int a = int.Parse(Console.ReadLine());
            switch(a)
            {
                case 1: Console.WriteLine("unu");
                    break;
                case 2: Console.WriteLine("doi");
                    break;
                case 3: Console.WriteLine("trei");
                    break;
                case 5: Console.WriteLine("cinci");
                    break;
                case 8: Console.WriteLine("opt");
                    break;
                default: Console.WriteLine("neidentificat");
                    break;
            }
        }
    }
}
