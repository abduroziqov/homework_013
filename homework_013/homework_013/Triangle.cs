using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace homework_013
{
    internal class Triangle
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int ThirdNumber { get; set; }

        public Triangle()
        {
            FirstNumber = 0;
            SecondNumber = 0;
        }
        
        public Triangle(int firstName, int secondNumber,int thirdNumber)
        {
            FirstNumber = firstName;
            SecondNumber = secondNumber;
            ThirdNumber = thirdNumber;
        }

        public void Perimetr()
        {
            int perimeter = FirstNumber + SecondNumber + ThirdNumber;
            Console.WriteLine($"The perimeter of the triangle : {perimeter}");
        }

        public void Square()
        {
            int square = FirstNumber * SecondNumber * ThirdNumber;
            Console.WriteLine($"The square of the triangle : {square}");
        }
    }

   
}
