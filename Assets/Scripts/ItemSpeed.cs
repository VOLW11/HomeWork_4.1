using UnityEngine;

public class ItemSpeed : Item
{
    [SerializeField] private float _valueSpeed;

    public ItemSpeed(float valueSpeed)
    {
        _valueSpeed = valueSpeed;
    }

    public override void UseEffect()
    {
        throw new System.NotImplementedException();
    }

}
