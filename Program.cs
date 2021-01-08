using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 10, 12, 14, 16, 18 };
            meuArray[0] = 12;

            Console.WriteLine(meuArray.Length);

            for (var index = 0; index <= meuArray.Length; index++)
            {
                Console.WriteLine(meuArray[index]);
            }

        }
    }
}
