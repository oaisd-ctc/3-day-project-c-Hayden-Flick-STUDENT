public class Enemy : Entity
{
    public Enemy(string NAME, int HP, int STR, int MGK, int DEF, int MDEF, int SPE) : base(NAME, HP, STR, MGK, DEF, MDEF, SPE)
    {
        
    }
    public void atkP(Player target)
    {
        Console.WriteLine("-_-_-_-_-_-_-_-");
        Console.WriteLine($"{this.GetName()} attacked {target.GetName()}");
        target.SetHP(target.GetHP()-(((this.GetStr() * 5 + RollForDamage())/target.GetDef()) + (this.GetSpe()/target.GetSpe())));
        if(target.GetHP() <= 0)
        {
            Console.WriteLine($"{target.GetName()} has been defeated.");
            target.SetHP(0);
            target.alive = false;
        }
    }
    public void atkM(Player target)
    {
        Console.WriteLine("-_-_-_-_-_-_-_-");
        Console.WriteLine($"{this.GetName()} unleashed a spell on {target.GetName()}");
        target.SetHP(target.GetHP()-(((this.GetMgk() * 5 + RollForDamage())/target.GetMdef()) + (this.GetSpe()/target.GetSpe())));
        if(target.GetHP() <= 0)
        {
            Console.WriteLine($"{target.GetName()} has been defeated.");
            target.SetHP(0);
            target.alive = false;
        }
    }
}