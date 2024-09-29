using UnityEngine;

public class Shot : Item
{
    public override void UseEffect()
    {
        _ability.TakeShot();

        base.UseEffect();
    }
}
