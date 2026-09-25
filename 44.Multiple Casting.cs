using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }
}

class Puppy : Dog
{
    public void Play()
    {
        Console.WriteLine("Puppy is playing");
    }
}

class Program
{
    static void Main()
    {
        
        Puppy puppy = new Puppy();

        
        Dog dog = (Dog)puppy;
        dog.Bark();

       
        Animal animal = (Animal)puppy;
        animal.Eat();

        
        Puppy puppy2 = (Puppy)dog;
        puppy2.Play();
    }
}
