using System;
using System.Collections.Generic;
class Device
{
    public string Name { get; }
    public bool IsOn { get; private set; }

    public Device(string name)
    {
        Name = name;
        IsOn = false;
    }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine($"{Name} is now ON.");
    }

     public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine($"{Name} is now OFF.");
    }
}