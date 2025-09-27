using System;
using TypeOfAnimal;

namespace TypeOfDog
{
    public class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("woof!");
    }
}

