using System;
using System.Collections.Generic;
class Room
{
    public string Name { get; }
    private List<Device> devices;

    public Room(string name)
    {
        Name = name;
        devices = new List<Device>();
    }

    public void AddDevice(Device device)
    {
        devices.Add(device);
    }

    public List<Device> GetDevices()
    {
        return devices;
    }
}