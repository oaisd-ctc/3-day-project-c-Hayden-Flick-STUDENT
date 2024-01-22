public class Player : Entity
{
    public Player(string NAME, int HP, int STR, int MGK, int DEF, int MDEF, int SPE) : base(NAME, HP, STR, MGK, DEF, MDEF, SPE)
    {

    }
    public void atkP(Enemy target)
    {
        target.SetHP(target.GetHP()-((this.GetStr() * 5 + RollForDamage())/target.GetDef()));
    }
    public void atkM(Enemy target)
    {
        target.SetHP(target.GetHP()-((this.GetMgk() * 5 + RollForDamage())/target.GetMdef()));
    }
}