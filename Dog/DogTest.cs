using System;


namespace Dog
{
    class DogTest
    {
        public static void Main(String[] args)
        {
            Dog defaultDog = new Dog();
            Console.WriteLine(defaultDog.ToString());

            Dog newDog = new Dog(7, "Rosie");
            Console.WriteLine(newDog.ToString());
            Console.WriteLine(newDog.CalcDogYears().ToString());
        }
    }
}

