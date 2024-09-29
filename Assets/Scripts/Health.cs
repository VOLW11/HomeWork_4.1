using UnityEngine;

public class Health : Item
{
    [SerializeField] private int _valueHealth;

    public override void UseEffect()
    {
        _ability.IncreaseHealth(_valueHealth);

        base.UseEffect();
    }

}
