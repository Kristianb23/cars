using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    class SecondMethod
    {
        public void Second()
        {
            //Second way to do it.
            Cars[] cars = new Cars[3];
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Cars();
                Console.WriteLine("Please enter the following information about your car.");
                Console.WriteLine("What is the Model of your car?");
                var carModel = Console.ReadLine();
                Console.WriteLine("What is the Color of your car?");
                var carColor = Console.ReadLine();
                Console.WriteLine("What is the Year of your car?");
                var carYear = Console.ReadLine();
                cars[i].model = carModel;
                cars[i].color = carColor;
                cars[i].year = Int32.Parse(carYear);
            }

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Your car is a " + cars[i].model + " " + cars[i].color + " " + cars[i].year + ".");
            }
            Console.ReadLine();
        }
    }
}
