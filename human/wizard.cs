using System;

class Wizard : Human
{
    public Wizard(string name) : base(name){
        Intelligence = 25;
        health = 50;
        maxHealth = 50;
    }

    public override int? Attack(Enemy target)
    {
        int dam = this.Intelligence*3;
        target.health -= dam;
        if(target.health <= 0)
        {
            System.Console.WriteLine($"{Name} Leeched {target.Name} with your Blood Siphon for {dam} damage! and healed yourself for {dam} health!");
            target = null;
            return null;
        }
        else
        {
            if(maxHealth - health > this.Intelligence*3)
            {
                this.Health += dam;
                System.Console.WriteLine($"{Name} Leeched {target.Name} with your Blood Siphon for {dam} damage! and healed yourself for {dam} health!");
                return target.health;
            }
            else
            {
                this.health = this.maxHealth;
                return target.health;
            }
        }
        
    }
    // fireball!!!
    public override int? Fireball(Enemy target)
    {
        int dam = this.Intelligence*2;
        Random rng = new Random();
        double roll = rng.NextDouble();
        if(roll > .8)
        {
            dam += 15;
            System.Console.WriteLine($"{Name} attacked {target.Name} with Fireball for {dam} and hit for an additional 15 damage!");
            target.health -= dam;
        }
        else
        {
            target.health -= dam;
            System.Console.WriteLine($"{Name} used Fireball to attack {target.Name} for {dam} damage!");
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

}