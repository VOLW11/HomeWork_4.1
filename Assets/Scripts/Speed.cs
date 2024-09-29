using UnityEngine;

public class Speed : Item
{
    [SerializeField] private float _valueSpeed;

    public override void UseEffect(ImprovementsAbilities _ability)
    {
        _ability.IncreaseSpeed(_valueSpeed);

        base.UseEffect(_ability);
    }

}
