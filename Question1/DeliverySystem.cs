using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesOOP_S2W4.Question1
{
    public class DeliverySystem
    {
        public void deliverySystem()
        {
            Console.WriteLine("Delivery System App");
            Console.Write("Please, insert your zip code (DXX): ");
            string userZipcode = Console.ReadLine();
            string[] deliveryZipCode = { "D01", "D02", "D03", "D04", "D05", "D06", "D07", "D08", "D09", "D10" };
            foreach(string zipCode in deliveryZipCode)
            {
                if (zipCode.Contains(userZipcode))
                {
                    Console.WriteLine("Zip code found.");
                    break;
                }
                else
                {
                    Console.WriteLine("Zip code not found.");
                    break;
                }
            }
        }
    }
}
