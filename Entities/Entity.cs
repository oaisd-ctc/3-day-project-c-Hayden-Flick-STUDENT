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
    }
    
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

    public void DisplayStats()
    {
        System.Console.WriteLine($"{GetName()}(HP:{GetHP()}/{GetMaxHP()}, Str:{GetStr()}, Mgk:{GetMgk()}, Def:{GetDef()}, Mdef:{GetMdef()}, Spe:{GetSpe()})");
    }
}