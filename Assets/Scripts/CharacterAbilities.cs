using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAbilities : MonoBehaviour
{

    public int Health {get; private set;}
    public float AddSpeed {get; private set;}

    public void increaseHealth(int value)
    {
        Health += value;
    }

    public void increaseSpeed(float value)
    {
        AddSpeed +=  value;
    }

    public void GetWapon()
    {

    }
}
