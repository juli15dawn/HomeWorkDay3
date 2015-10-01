using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class AnimalUtility
    {
        public static void DoSomething(INoisyAnimal a)
        {
            Console.WriteLine("{0} says '{1}'", a.Name, a.MakeSound());
        }
    }

    interface INoisyAnimal : INoisy
    {
        string Name { get; }
    }

    interface INoisy
    {
        string MakeSound();
    }
    class Animal
    {
        public string Name { get; set; }
    }
    class Bear : Animal, INoisyAnimal
    {
        public Bear()
        {
            Name = "Bear";
        }

        public string MakeSound()
        {
            return "roar!";
        }
    }
    class Eagle : Animal, INoisyAnimal
    {
        public Eagle()
        {
            Name = "Eagle";
        }
        public string MakeSound()
        {
            return "squak";

        }
    }
    class Chicken : Animal, INoisyAnimal
    {
        public Chicken()
        {
            Name = "Chicken";
        }
        public string MakeSound()
        {
            return "peck";
        }
    }


    class Program
    {
        static string Thing { get; set; }
        static void Main(string[] args)
        {
            AnimalUtility.DoSomething(new Bear());
            Debug.Assert(new Bear().Name == "Bear", "This is not a bear");
            Console.ReadLine();
        }
    }
   
}
