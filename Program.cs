using ExercisesOOP_S2W4.Question1;
using System;

namespace ExercisesOOP_S2W4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises S2W4");
            Console.WriteLine("Question .1");
            Console.WriteLine("Question .2");
            Console.WriteLine("Question .3");
            Console.Write("Choose a question: ");
            int menuOpt = Convert.ToInt32(Console.ReadLine());
            switch (menuOpt)
            {
                case 1:
                    DeliverySystem system = new();
                    system.deliverySystem();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
            
        }
    }
}
