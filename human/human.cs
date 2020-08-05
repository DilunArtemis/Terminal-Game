using System;

class Human
{
    public int maxHealth;
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    protected int Health;
    public int health
    {
        get {return Health;}
        set {this.Health = value;}
    }

    public Human(string name, int str, int intelligence, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intelligence;
        Dexterity = dex;
        Health = hp;

    }

    public Human(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }

    public virtual int? Attack(Enemy target)
    {
        int dam = this.Strength*5;
        target.health -= dam;
        System.Console.WriteLine("");
        return target.health;
    }

    public virtual void Steal(Enemy target)
    {
        target.health -= 5;
        this.health += 5;
        
    }

    public virtual int Meditate()
    {
        this.health = 100;
        Console.WriteLine("");
        return this.health;
    }

    public virtual int? Fireball(Enemy target)
    {
        int dam = this.Intelligence*2;
        Random rng = new Random();
        double roll = rng.NextDouble();
        if(roll > .8)
        {
            dam += 15;
            System.Console.WriteLine("");
            target.health -= dam;
            if(target.health <= 0)
            {
                System.Console.WriteLine("");
                target = null;
                return null;
            }
            else
            {
                dam += 10;
                System.Console.WriteLine("");
                target.health -= dam;
                return target.health;
            }
        }
        else
        {
            target.health -= dam;
            System.Console.WriteLine("");
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
    }

}

