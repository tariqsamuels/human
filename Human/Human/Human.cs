using System;

namespace Human 
{
class HumanBeing
{
    // Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int health;

    public int Health
    {
        get {return health;}
    }
     
    public HumanBeing(string humanName)
    {
        Name = humanName;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        health = 100;
    }
     public HumanBeing(string humanName, int str, int intel, int dex, int paramHealth)
    {
        Name = humanName;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        health = paramHealth;
    }
    public int Attack(HumanBeing target)
    {
        target.health -= 5*Strength;
        return target.health;
    }
}

}