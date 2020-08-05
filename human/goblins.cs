class Goblin : Enemy{

public Goblin(string name) : base(){
    Name = name;
    Strength = 10;
    Intelligence = 25;
    Health = 55;
}

public int? Attack (Human target){
    int dmg = (Intelligence+(Strength/2));
    target.health -= dmg;
    System.Console.WriteLine($"{Name} hit you for {dmg} Damage!");
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