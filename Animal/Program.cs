using System;

abstract class Animal{

    public string Name {get; set;}
    public void Fun(){

        Console.WriteLine("Fun!");
    }
    public abstract void Speak();


}

class Dog:Animal{

    public override void Speak(){

        Console.WriteLine("Got any Treat!");
    }

}

class Cat:Animal{

    public override void Speak(){

        Console.WriteLine("Meow Meow");
    }

    public override string ToString(){

        return "I need lasagna!";
    }

    public override bool Equals(object obj)
    {

        if(this.GetType() == obj.GetType()){

            Cat temp = (Cat)obj;

            if(this.Name == temp.Name){

                return true;
            }

            else{

                return false;
            }
        }

        else {

            return false;
        }
    }

    public override int GetHashCode(){

        return base.GetHashCode();
    }
}
