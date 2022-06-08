using System;

namespace Ex1Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar;
            System.Console.WriteLine("Creating a Car object and assigning"
                + "its memory location to myCar");

            myCar = new Car();

            myCar.Make = "Toyota";
            myCar.Model = "MR2";
            myCar.Color = "Black";
            myCar.yearBuilt = 1995;

            // display
            System.Console.WriteLine("My Car details: ");
            System.Console.WriteLine("myCar.Make = " + myCar.Make);
            System.Console.WriteLine("myCar.Model = "+ myCar.Model);
            System.Console.WriteLine("myCar.Color = " + myCar.Color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);

            myCar.Start();
            myCar.Stop();

            // Create another Car object
            System.Console.WriteLine("Creating another Car object and"
                + "assigning its memory location to redPorsche");
            Car redPorsche = new Car();
            redPorsche.Make = "Porsche";
            redPorsche.Model = "Boxster";
            redPorsche.Color = "red";
            redPorsche.yearBuilt = 2000;
            System.Console.WriteLine("redPorsche is a " + redPorsche.Model);
            System.Console.WriteLine("Assigning redPorscher to myCar");
            myCar = redPorsche;
            System.Console.WriteLine("My Car details: ");
            System.Console.WriteLine("myCar.Make = " + myCar.Make);
            System.Console.WriteLine("myCar.Model = " + myCar.Model);
            System.Console.WriteLine("myCar.Color = " + myCar.Color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);
            // assign null myCar (myCar will no longer reference an object)
            myCar = null;
            Console.ReadLine();
        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int yearBuilt { get; set; }

        public void Start()
        {
            System.Console.WriteLine(Model + "started");
        }

        public void Stop()
        {
            System.Console.WriteLine(Model + "Stopped");

        }
    }
}

