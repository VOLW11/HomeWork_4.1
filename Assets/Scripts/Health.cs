using UnityEngine;
using static UnityEditor.Progress;

public class Health : Item
{
    [SerializeField] private int _valueHealth;

    public override void UseEffect()
    {
        _ability.increaseHealth(_valueHealth);

        base.UseEffect();
    }

}
