using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars
{
    class FirstMethod
    {
        public void First()
        {
            //First way to do it.
            var carInput = new Cars();
            Console.WriteLine("Welcome! Please enter the following information about first your car.");
            Console.WriteLine("What is the Model of your car?");
            var firstCarModel = Console.ReadLine();
            Console.WriteLine("What is the Color of your car?");
            var firstCarColor = Console.ReadLine();
            Console.WriteLine("What is the Year of your car?");
            var firstCarYear = Console.ReadLine();

            carInput.model = firstCarModel;
            carInput.color = firstCarColor;
            carInput.year = Int32.Parse(firstCarYear);
            Console.WriteLine("Your car is a " + carInput.model + " " + carInput.color + " " + carInput.year + ".");

            Console.WriteLine("Please enter the following information about your second car.");
            Console.WriteLine("What is the Model of your car?");
            var secondCarModel = Console.ReadLine();
            Console.WriteLine("What is the Color of your car?");
            var secondCarColor = Console.ReadLine();
            Console.WriteLine("What is the Year of your car?");
            var secondCarYear = Console.ReadLine();
            var carInput2 = new Cars();
            carInput2.model = secondCarModel;
            carInput2.color = secondCarColor;
            carInput2.year = Int32.Parse(secondCarYear);
            Console.WriteLine("Your car is a " + carInput2.model + " " + carInput2.color + " " + carInput2.year + ".");

            Console.WriteLine("Please enter the following information about your third car.");
            Console.WriteLine("What is the Model of your car?");
            var thirdCarModel = Console.ReadLine();
            Console.WriteLine("What is the Color of your car?");
            var thirdCarColor = Console.ReadLine();
            Console.WriteLine("What is the Year of your car?");
            var thirdCarYear = Console.ReadLine();
            var carInput3 = new Cars();
            carInput3.model = thirdCarModel;
            carInput3.color = thirdCarColor;
            carInput3.year = Int32.Parse(thirdCarYear);
            Console.WriteLine("Your car is a " + carInput3.model + " " + carInput3.color + " " + carInput3.year + ".");

            Console.WriteLine("Thank you for entering your car information. Here is a list of your cars.");
            Console.WriteLine("Car 1: " + carInput.model + " " + carInput.color + " " + carInput.year + ".");
            Console.WriteLine("Car 2: " + carInput2.model + " " + carInput2.color + " " + carInput2.year + ".");
            Console.WriteLine("Car 3: " + carInput3.model + " " + carInput3.color + " " + carInput3.year + ".");

            Console.ReadLine();
        }
    }
}
