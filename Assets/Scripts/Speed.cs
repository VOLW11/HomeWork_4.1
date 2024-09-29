using UnityEngine;

public class Speed : Item
{
    [SerializeField] private float _valueSpeed;

    public override void UseEffect()
    {
        _ability.increaseSpeed(_valueSpeed);

        base.UseEffect();
    }

}
