using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var honda = new Car();
            honda.EngineNoise = "Shhh";
            honda.HonkNoise = "Peep";
            honda.IsDriveable = true;
            honda.Make = "Honda";
            honda.Model = "CR-V";
            honda.Year = 2015;






            var mazda = new Car();
            mazda.EngineNoise = "Vroom";
            mazda.HonkNoise = "TTT";
            mazda.IsDriveable = false;
            mazda.Make = "Mazda";
            mazda.Model = "Protege";
            mazda.Year = 2016;


            Car nissan = new Car();

            nissan.EngineNoise = "Clak clak";
            nissan.HonkNoise = "chap chap";
           nissan.IsDriveable = true;
            nissan.Make = "Nissan";
            nissan.Model = "Altima";
            nissan.Year = 2018;

            mazda.MakeEngineNoise(mazda.EngineNoise);
            mazda.MakeHonkNoise(mazda.HonkNoise);

            nissan.MakeEngineNoise(nissan.EngineNoise);
            nissan.MakeHonkNoise(nissan.HonkNoise);

            honda.MakeEngineNoise(honda.EngineNoise);
            honda.MakeHonkNoise(honda.HonkNoise);


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
