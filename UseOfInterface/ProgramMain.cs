using System;

namespace UseOfInterface
{
    class ProgramMain: Interface1, Interface2
    {
         void Interface1.Add(int firstNumber,int secondNumber)
        {
            Console.WriteLine("InterFace 1 add"+" "+ firstNumber +secondNumber);
        }
         void Interface2.Add(double firstNumber, double secondNumber)
        {
            Console.WriteLine("InterFace 2 add" + " " + firstNumber + secondNumber);
        }
        public void Sub(int firstNumber, int secondNumber)
        {
            Console.WriteLine( firstNumber - secondNumber);
        }
        public void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine("multiply" + " " +  firstNumber * secondNumber);
        }
        static void Main(string[] args)
        {
            ProgramMain obj = new ProgramMain();
            Interface1 interface1 = obj;
            Interface2 interface2 = obj;
            interface1.Add(9, 8);
            interface2.Add(2.4, 4.5);
            obj.Sub(12, 8);
            obj.Multiply(12, 3);
            Console.ReadLine();
        }
    }
}
