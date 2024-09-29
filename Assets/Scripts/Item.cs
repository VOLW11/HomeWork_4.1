using Unity.VisualScripting;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] protected ImprovementsAbilities _ability;
    [SerializeField] Transform _particleSystemPrefab;



    public virtual void UseEffect()
    {
        Instantiate(_particleSystemPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
