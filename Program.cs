using System;
using System.Collections.Generic;
namespace ConsoleApplication
{
public class Human
    {
        public string Name;
        public int Strength = 3;
        public int Intelligence = 3;
        public int Dexterity = 3;
        public int Health = 100;

        public Human(string val)
        {
            Name = val;
        }
        public Human(int Str, int Dex, int Int, int HP, string Alias){
            Strength = Str;
            Intelligence = Int;
            Dexterity = Dex;
            Health = HP;
            Name = Alias;
        }
         public void Attack(Human user)
       {
           Console.WriteLine(Name + " Is Attacking " + user.Name + "!");
           user.Health -= Strength * 5;
           Console.WriteLine(user.Name + " receives " + Strength * 5 + " pts of damage and has " + user.Health + "hp left");
       }
    }
public class Program
{
    public static void Main(string[] args)
    {
        Human cassidy = new Human(1,2,3,100,"Cassidy");
        Console.WriteLine($"my human is {cassidy.Name}");
        Human preeya = new Human(2,3,2,100,"preeya" );
        cassidy.Attack(preeya);
    }

}

// public class Vehicle
// {
//      public int numPassengers;
//      public double distance = 0.0;
//      public Vehicle(int val)
//      {
//           numPassengers = val;
//      }
//     public int Move(double miles)
//     {
//         distance += miles;
//         return (int)distance;
//     }
// }
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         //We create two separate objects of class-Vehicle
//         Vehicle car = new Vehicle(5);
//         Vehicle bike = new Vehicle(1);
//         //Notice they both have the same starting distance travelled
//         Console.WriteLine(car.distance); //Prints 0
//         Console.WriteLine(bike.distance); //Also Prints 0
//         //The Move method however only effects the distance of the object it is referencing!!
//         car.Move(70.8);
//         Console.WriteLine(car.distance); //Now is printing 70.8
//         Console.WriteLine(bike.distance); //Still prints 0
//     }
// }
}