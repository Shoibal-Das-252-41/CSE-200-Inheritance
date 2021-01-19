using System;

namespace Inheritance
{
    class Program
    {
        class Car
        {
            public string brand;
            public string color;
            public int price;

            public void DisplyaCarInfo()
            {
                Console.WriteLine("Brand : " + brand);
                Console.WriteLine("Color : " + color);
                Console.WriteLine("Price : " + price);
            }
        }

        class RangeRover : Car
        {
            float mileage;

            void DisplayMileage()
            {
                Console.WriteLine("Mileage : " + mileage);
            }

            static void Main(string[] args)
            {

                RangeRover myCar = new RangeRover();
                myCar.brand = "Range Rover";
                myCar.color = "Desert";
                myCar.price = 20000000;
                myCar.mileage = 34.7f;
                myCar.DisplyaCarInfo();
                myCar.DisplayMileage();
                Console.ReadLine();

            }
        }
    }
}
