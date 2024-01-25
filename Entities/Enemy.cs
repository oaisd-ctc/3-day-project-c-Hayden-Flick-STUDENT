public class Enemy : Entity
{
    public Enemy(string NAME, int HP, int STR, int MGK, int DEF, int MDEF, int SPE) : base(NAME, HP, STR, MGK, DEF, MDEF, SPE)
    {
        
    }
    public void atkP(Player target)
    {
        target.SetHP(target.GetHP()-(((this.GetStr() * 5 + RollForDamage())/target.GetDef()) + (this.GetSpe()/target.GetSpe())));
        if(target.GetHP() <= 0)
        {
            target.SetHP(0);
            target.alive = false;
        }
    }
    public void atkM(Player target)
    {
        target.SetHP(target.GetHP()-(((this.GetMgk() * 5 + RollForDamage())/target.GetMdef()) + (this.GetSpe()/target.GetSpe())));
        if(target.GetHP() <= 0)
        {
            target.SetHP(0);
            target.alive = false;
        }
    }
}