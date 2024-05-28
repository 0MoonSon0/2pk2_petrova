namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            for (int i = 10; i <= 60; i += 3)
            {
                Console.WriteLine(i);
            }

            //2
            char start = 'Д';
            
            for (int i = 0; i < 7; i++)
            {
                Console.Write((char)(start + i) + " ");
            }

            Console.WriteLine();

            //3
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            
            //4
            int count = 0;

            for (int i = -300; i <= 200; i++)
            {                
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Количество кратных чисел: " + count);

            //5
            int a = 5;
            int b = 62;

            while (Math.Abs(a - b) > 32)
            {
                Console.WriteLine($"a: {a}, b: {b}");
                a++;
                b--;
            }

            Console.WriteLine($"a: {a}, b: {b}");
            Console.WriteLine($"Разница между a и b: {Math.Abs(a - b)}");

        }
    }

}
