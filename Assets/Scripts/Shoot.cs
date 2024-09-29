using UnityEngine;

public class Shoot : Item
{
    public override void UseEffect(ImprovementsAbilities _ability)
    {
        _ability.TakeShoot();

        base.UseEffect(_ability);
    }
}
