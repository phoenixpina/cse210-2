using System;

public abstract class Animal 
{
    public string name;

    protected Animal(string name) //constructor. Protected means only the children (extended classes) can call it
    {
        this.name = name;
    }
    public virtual void MakeSound() //virtual means ready for override
    {
        Console.WriteLine("Speaks Not");
    }

        public string GetName()
    {
        return name;
    }
}