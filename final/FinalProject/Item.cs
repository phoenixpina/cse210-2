//All class files relating to Items will start with an "I" for easy locating in the sidebar.
//All specific items are found within the DropItem method in the Enemy class.
public class Item
{
    public string _name;
    public string _description;

    public Item(string Name, string Description)
    {
        _name = Name;
        _description = Description;
    }
}