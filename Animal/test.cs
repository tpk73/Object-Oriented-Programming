using System;

class test{

    public static void Main(string[] args){

        Dog goofy = new Dog();
        goofy.Speak();

        Cat garfield = new Cat();
        garfield.Name = "garfield";
        garfield.Speak();

        Cat boots = new Cat();
        boots.Name = "boots";
        boots.Speak();

        Console.WriteLine(garfield.ToString());
        Console.WriteLine(garfield.GetType());
        Console.WriteLine(garfield.GetHashCode());

        Console.WriteLine(garfield.Equals(boots));
        Console.WriteLine(garfield.Equals(1));
        Console.WriteLine(garfield.Equals(garfield));
        
    }
}