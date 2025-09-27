using System;
using System.Runtime.InteropServices;

namespace TypeOfAnimal
{
    public abstract class Animal
    {
        public abstract void Speak();
        public void Breathe() => Console.WriteLine("Breathing...");
    }
}
