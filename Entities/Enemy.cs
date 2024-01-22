public class Enemy : Entity
{
    public Enemy(string NAME, int HP, int STR, int MGK, int DEF, int MDEF, int SPE) : base(NAME, HP, STR, MGK, DEF, MDEF, SPE)
    {
        
    }
    public void atkP(Player target)
    {
        target.SetHP(this.str);
    }
    public void atkM(Player target)
    {
        target.SetHP(this.mgk);
    }
}