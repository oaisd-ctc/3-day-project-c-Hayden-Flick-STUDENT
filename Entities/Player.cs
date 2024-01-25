public class Player : Entity
{
    public Player(string NAME, int HP, int STR, int MGK, int DEF, int MDEF, int SPE) : base(NAME, HP, STR, MGK, DEF, MDEF, SPE)
    {

    }
    public void atkP(Enemy target)
    {
        target.SetHP(target.GetHP()-(((this.GetStr() + this.GetSpe()) * 5 + RollForDamage())/(target.GetDef() + target.GetSpe())));
        if(target.GetHP() <= 0)
        {
            target.SetHP(0);
            target.alive = false;
        }
    }
    public void atkM(Enemy target)
    {
        target.SetHP(target.GetHP()-(((this.GetStr() + this.GetSpe()) * 5 + RollForDamage())/(target.GetDef() + target.GetSpe())));
        if(target.GetHP() <= 0)
        {
            target.SetHP(0);
            target.alive = false;
        }
    }
}