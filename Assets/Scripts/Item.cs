using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private Transform _particleSystemPrefab;

    public virtual void UseEffect(ImprovementsAbilities _ability)
    {
        Instantiate(_particleSystemPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
