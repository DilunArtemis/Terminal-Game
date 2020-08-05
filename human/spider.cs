class Spider : Enemy
{
    public Spider(string name) : base()
    {
        Name = name;
        Dexterity = 100;
    }

    public int? Attack(Human target)
    {
        int dmg = Dexterity/10;
        target.health -= dmg;
        System.Console.WriteLine($"{Name} hit you for {dmg} Damage!");
        if (target.health <= 0)
        {
            System.Console.WriteLine($"{Name} has killed {target.Name}.");
            target = null;
            return null;
        }
        return target.health;
    }
}