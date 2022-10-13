using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    class ThirdMethod
    {
        public void Third()
        {
            //Third way to do it
            //First Car Text Strings
            var firstModel = "Whats the Model of the first car?";
            var secondModel = "Whats the Model of the second car?";
            var thirdModel = "Whats the Model of the third car?";

            //Second Car Text Strings
            var firstColor = "Whats the Color of the first car?";
            var secondColor = "Whats the Color of the second car?";
            var thirdColor = "Whats the Color of the third car?";

            //Third Car Text Strings
            var firstYear = "Whats the Year of the first car?";
            var secondYear = "Whats the Year of the second car?";
            var thirdYear = "Whats the Year of the third car?";

            var firstCar = "Your first car is: ";
            var secondCar = "Your second car is: ";
            var thirdCar = "Your third car is: ";

            var carsThird = new List<Cars>();
            for (int i = 0; i < 3; i++)
            {
                var car = new Cars();
                if (i == 0)
                {
                    Console.WriteLine(firstModel);
                }
                else if (i == 1)
                {
                    Console.WriteLine(secondModel);
                }
                else
                {
                    Console.WriteLine(thirdModel);
                }

                car.model = Console.ReadLine();
                if (i == 0)
                {
                    Console.WriteLine(firstColor);
                }
                else if (i == 1)
                {
                    Console.WriteLine(secondColor);
                }
                else
                {
                    Console.WriteLine(thirdColor);
                }

                car.color = Console.ReadLine();
                if (i == 0)
                {
                    Console.WriteLine(firstYear);
                }
                else if (i == 1)
                {
                    Console.WriteLine(secondYear);
                }
                else
                {
                    Console.WriteLine(thirdYear);
                }

                car.year = int.Parse(Console.ReadLine());
                carsThird.Add(car);
            }

            foreach (var car in carsThird)
            {
                if (car == carsThird[0])
                {
                    Console.WriteLine(firstCar + car.model + " " + car.color + " " + car.year);
                }
                else if (car == carsThird[1])
                {
                    Console.WriteLine(secondCar + car.model + " " + car.color + " " + car.year);
                }
                else
                {
                    Console.WriteLine(thirdCar + car.model + " " + car.color + " " + car.year);
                }
            }
        }
    }
    }

