public class Entity
{
    protected string name;
    protected int hp;
    protected int maxHP;
    protected int str;
    protected int mgk;
    protected int def;
    protected int mdef;
    protected int spe;
    public bool alive;
    public Entity(string NAME,  int HP, int STR, int MGK, int DEF, int MDEF, int SPE)
    {
        this.name = NAME;
        this.hp = HP;
        this.maxHP = HP;
        this.str = STR;
        this.mgk = MGK;
        this.def = DEF;
        this.mdef = MDEF;
        this.spe = SPE;
        this.alive = true;
    }
    //getters
    public string GetName()
    {
        return name;
    }
    public int GetHP()
    {
        return hp;
    }
    public int GetMaxHP()
    {
        return maxHP;
    }
    public int GetStr()
    {
        return str;
    }
    public int GetMgk()
    {
        return mgk;
    }
    public int GetDef()
    {
        return  def;
    }
    public int GetMdef()
    {
        return mdef;
    }
    public int GetSpe()
    {
        return spe;
    }

    public bool GetAlive()
    {
        return alive;
    }
    //setters
    public void SetHP(int damage)
    {
        hp = damage;
    }
    public void atkP(Entity target)
    {
        target.SetHP(target.GetHP()-(((this.GetStr() * 5 + RollForDamage())/target.GetDef()) + (this.GetSpe()/target.GetSpe())));
        if(target.GetHP() <= 0)
        {
            target.SetHP(0);
            target.alive = false;
        }
    }
    public void atkM(Entity target)
    {
        target.SetHP(target.GetHP()-(((this.GetMgk() * 5 + RollForDamage())/target.GetMdef()) + (this.GetSpe()/target.GetSpe())));
        {
            target.SetHP(0);
            target.alive = false;
        }
    }
    //miscellaneous
    public void DisplayStats()
    {
        if(this.alive)
        {
            System.Console.WriteLine($"{GetName()}(HP:{GetHP()}/{GetMaxHP()}, Str:{GetStr()}, Mgk:{GetMgk()}, Def:{GetDef()}, Mdef:{GetMdef()}, Spe:{GetSpe()})");
        }
        else
        {
            System.Console.WriteLine($"{GetName()}(Defeated HP:{GetHP()}/{GetMaxHP()})");
        }
    }
    protected int RollForDamage()
    {
        Random dice = new Random();
        int roll = dice.Next(0,21);
        return roll;
    }
}