using UnityEngine;
using static UnityEditor.Progress;

public class ItemHealth : Item
{
    [SerializeField] private float _valueHealth;

    public override void UseEffect()
    {
        Debug.Log("Çהמנמגüו");
        //Destroy(gameObject);
    }

}
