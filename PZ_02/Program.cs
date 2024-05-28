namespace PZ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите действительное число a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите целое число c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            double x = 0;
            double y = 0;
            

            if (a > Math.PI)
            {
                x = (Math.Cos(a + (2 * c)));
            }
            else if ( a <= Math.PI )
            {
                x = (c + Math.Sqrt(a * Math.Pow(c, 2) - 2 * (a + Math.PI)));
            }

            if(x <= 0)
            {
                y = (Math.Log(a + c - x));
            }
            else if (x > 0)
            {
                y = (Math.Sin(2 * a * x) + Math.Sin(a + x));
            }

            double z = (2 * x + 3 * y) * (Math.Pow(a, 2) - Math.Pow(c, 2));



            Console.WriteLine($"Число Х = {x}\n\n Число Y = {y}\n\n Число Z = {z}");
        }
    }
}
