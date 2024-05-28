namespace PZ_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите фигуру: круг, прямоугольник или треугольник");
            string figura = Console.ReadLine();

            double area = 0;

            switch (figura)
            {
                case "круг":
                    Console.WriteLine("Введите радиус круга:");
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
                case "прямоугольник":
                    Console.WriteLine("Введите длину прямоугольника:");
                    double length = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите ширину прямоугольника:");
                    double width = double.Parse(Console.ReadLine());
                    area = length * width;
                    break;
                case "треугольник":
                    Console.WriteLine("Введите высоту треугольника:");
                    double height = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите основание треугольника:");
                    double baseLength = double.Parse(Console.ReadLine());
                    area = 0.5 * baseLength * height;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод.");
                    return;
            }

            Console.WriteLine($"Площадь {figura}а: {area}");

        }
    }
}
