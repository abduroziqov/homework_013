namespace homework_013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first side : ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter first side : ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter first side : ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(firstNumber,secondNumber,thirdNumber);

            triangle.Perimetr();
            triangle.Square();

        }
    }
}