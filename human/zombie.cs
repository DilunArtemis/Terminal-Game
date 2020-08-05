class Zombie : Enemy
{
    public Zombie(string name) : base()
    {
        Name = name;
        health = 55;
    }
        

    public int? Attack(Human target)
    {
        int dam = Strength/2;
        target.health -= dam;
        System.Console.WriteLine($"{Name} hit you for {dam} Damage!");
        if(target.health >= 0)
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