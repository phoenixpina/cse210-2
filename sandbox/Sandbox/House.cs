using System;
using System.Collections.Generic;
class House
{
    private List<Room> rooms;

    public House()
    {
        rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        rooms.Add(room);
    }

    public List<Room> GetRooms()
    {
        return rooms;
    }
}