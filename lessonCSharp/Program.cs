using System;

namespace lessonCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a triangle height: ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("Please enter a triangle width: ");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i <=height; i++)
            {
                for (int x = 0; x <= width; x++)
                {
                    if ( x <= i)
                    {
                        Console.Write('@');
                        continue;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
