class Enemy
{
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    protected int Health;
    public int health{
        get {return Health;}
        set {this.Health = value;}
    }

    public Enemy()
    {
        Strength = 25;
        Intelligence = 0;
        Dexterity = 1;
        health = 50;
    }
}
