using System;
class Samurai : Human
{
    public Samurai(string name) : base(name)
    {
        health = 200;
        maxHealth = 200;
    }

    public override int? Attack(Enemy target)
    {
        if(target.health < 50)
        {
            target = null;
            return null;
        }
        else
        {
            base.Attack(target);
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
        // return target.health;
    }
// self heal
    public override int Meditate()
    {
        this.health += 100;
        Console.WriteLine($"{Name} healed 100!");
        return this.health;
    }

}