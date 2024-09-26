using UnityEngine;

public  class Item : MonoBehaviour
{
    private CharacterAbilities _abilities;


    public virtual void UseEffect()
    {
        _abilities.increaseHealth(10);
    }
}
