﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.Year = 1994;
            car1.Make = "Ford";
            car1.Model = "Explorer";
            car1.EngineNoise = "yes";
            car1.HonkNoise = "yes";
            car1.IsDrivable = "no";

            Console.WriteLine($"The car is a {car1.Year} {car1.Make} {car1.Model}. {car1.CarIsDriveable(car1.IsDrivable)} {car1.MakeEngineNoise(car1.EngineNoise)} {car1.MakeHonkNoise(car1.HonkNoise)}");
            CarLot.AddCar();
            Console.WriteLine("Number of cars in the car lot: " + CarLot.numberOfCars);

            Car car2 = new Car();
            car2.Year = 2002;
            car2.Make = "Porsche";
            car2.Model = "911";
            car2.EngineNoise = "no";
            car2.HonkNoise = "yes";
            car2.IsDrivable = "yes";


            Console.WriteLine($"The car is a {car2.Year} {car2.Make} {car2.Model}. {car2.CarIsDriveable(car2.IsDrivable)} {car2.MakeEngineNoise(car2.EngineNoise)} {car2.MakeHonkNoise(car2.HonkNoise)}");
            CarLot.AddCar();
            Console.WriteLine("Number of cars in the car lot: " + CarLot.numberOfCars);

            Car car3 = new Car();
            car3.Year = 2015;
            car3.Make = "Honda";
            car3.Model = "Accord";
            car3.EngineNoise = "no";
            car3.HonkNoise = "no";
            car3.IsDrivable = "yes";
            Console.WriteLine($"The car is a {car3.Year} {car3.Make} {car3.Model}. {car3.CarIsDriveable(car3.IsDrivable)} {car3.MakeEngineNoise(car3.EngineNoise)} {car3.MakeHonkNoise(car3.HonkNoise)}");
            CarLot.AddCar();
            Console.WriteLine("Number of cars in the car lot: " + CarLot.numberOfCars);


            //TODO

            //Create a seperate class file called Car - DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE
            //The methods should take one string parameter: the respective noise property - DONE


            //Now that the Car class is created we can instanciate 3 new cars - DONE
            //Set the properties for each of the cars - DONE
            //Call each of the methods for each car - DONE

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
