using LabWorkLibrary;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Сумма = {Maths.GetSum(40, 24)}");
            Console.WriteLine($"Разность = {Maths.GetDifference(40, 24)}");
            Console.WriteLine($"Произведение = {Maths.GetMultiplication(40, 24)}");
            Console.WriteLine($"Частное = {Maths.GetDivision(40, 24)}");
            Console.WriteLine($"Площадь = {Maths.GetRectangleArea(40, 24)}");
            Console.WriteLine($"Константа = {Maths.BINARY_FACTOR}");
        }
    }
}