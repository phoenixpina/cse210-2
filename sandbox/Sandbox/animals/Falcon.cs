class Falcon : Animal //extending class
{
    private string sound;
        public Falcon(string name, string sound) : base(name)
    {
        this.sound = sound;
    }
    public override void MakeSound()
    {
        //Console.WriteLine("Holloman Middle sucks, yeehaw");
        Console.WriteLine($"{this.name} says {this.sound}");
    }
}