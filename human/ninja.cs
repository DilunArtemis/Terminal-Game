using System;

class Ninja : Human
{
    
    public Ninja(string name) : base(name)
    {
        Dexterity = 175;
        maxHealth = 100;
    }

    public override int? Attack(Enemy target)
    {
        int dam = this.Dexterity/4;
        Random rng = new Random();
        double roll = rng.NextDouble();
        if(roll > .8)
        {
            dam += 10;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dam} and hit for an additional 10 damage!");
            target.health -= dam;
        }
        else
        {
            target.health -= dam;
            System.Console.WriteLine($"{Name} attacked {target.Name} for {dam} damage!");
            if(target.health <= 0)
            {
                target = null;
                return null;
            }
            else
            {
                return target.health;
            }
        }
        return target.health;
    }
    public override void Steal(Enemy target)
    {
        int dam = 5;
        target.health -= dam;
        this.health += 5;
        Console.WriteLine($"{Name} stole {dam} health from {target.Name}!");

    }
}