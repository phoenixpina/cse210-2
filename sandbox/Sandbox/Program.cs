using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var myHouse = new House();

        while (true)
        {
            Console.WriteLine("1. Living Room");
            Console.WriteLine("2. Kitchen");
            Console.WriteLine("3. Exit");
            Console.Write("Choose a room (1-3): ");
            int roomChoice;

            if (!int.TryParse(Console.ReadLine(), out roomChoice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            switch (roomChoice)
            {
                case 1:
                  //  if (myHouse.GetRooms().Length >= 1) 
                        HandleRoom(myHouse.GetRooms()[0]); // Living Room
                 //  else
                        Console.WriteLine("Living Room data not available.");
                    break;
                case 2:
                    HandleRoom(myHouse.GetRooms()[1]); // Kitchen
                    break;
                case 3:
                    Console.WriteLine("Good luck out there.");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void HandleRoom(Room room)
    {
        Console.WriteLine($"You are in the {room.Name}.");
        Console.WriteLine("1. Control specific device");
        Console.WriteLine("2. Turn all devices on/off");
        Console.WriteLine("3. Go back");
        Console.Write("Choose an option (1-3): ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                HandleDevice(room);
                break;
            case 2:
                Console.WriteLine("1. Turn all devices ON");
                Console.WriteLine("2. Turn all devices OFF");
                Console.Write("Choose an option (1-2): ");
                int allDevicesOption = int.Parse(Console.ReadLine());

                switch (allDevicesOption)
                {
                    case 1:
                        foreach (var device in room.GetDevices())
                        {
                            device.TurnOn();
                        }
                        break;
                    case 2:
                        foreach (var device in room.GetDevices())
                        {
                            device.TurnOff();
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                break;
            case 3:
                Console.WriteLine("Going back to main menu.");
                return; // Return to the main menu loop
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    static void HandleDevice(Room room)
    {
        Console.WriteLine($"Devices in {room.Name}:");
        var devices = room.GetDevices();

        for (int i = 0; i < devices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {devices[i].Name}");
        }

        Console.Write("Choose a device (1-{devices.Count}): ");
        int deviceChoice = int.Parse(Console.ReadLine());

        if (deviceChoice >= 1 && deviceChoice <= devices.Count)
        {
            var selectedDevice = devices[deviceChoice - 1];
            Console.WriteLine($"Selected device: {selectedDevice.Name}");
            Console.WriteLine("1. Turn ON");
            Console.WriteLine("2. Turn OFF");
            Console.WriteLine("3. Go back");
            Console.Write("Choose an option (1-3): ");
            int actionChoice = int.Parse(Console.ReadLine());

            switch (actionChoice)
            {
                case 1:
                    selectedDevice.TurnOn();
                    break;
                case 2:
                    selectedDevice.TurnOff();
                    break;
                case 3:
                    Console.WriteLine("Going back to the previous menu.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid device choice. Please try again.");
        }
    }
}



