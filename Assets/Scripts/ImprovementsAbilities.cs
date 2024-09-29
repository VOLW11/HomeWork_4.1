using UnityEngine;

public class ImprovementsAbilities : MonoBehaviour
{
    [SerializeField] private int _defaultHealth;
    [SerializeField] private float _defaultSpeed;

    [SerializeField] private Bullet _bulletPrefab;//
    [SerializeField] private Transform _shootPoint;//

    public int Health {get; private set;} 
    public float Speed {get; private set;}

    private void Awake()
    {
        Health = _defaultHealth;
        Speed = _defaultSpeed;
        Debug.Log(Health);
        Debug.Log(Speed);
    }

    public void increaseHealth(int value)
    {
        Debug.Log(Health);
        Debug.Log(value);
        Health += value;
        Debug.Log($"HP увеличено на {value}: {Health}");
        Debug.Log(Health);
    }

    public void increaseSpeed(float value)
    {
        Speed +=  value;
        Debug.Log($"Скорость увеличена на {value}: {Speed}");
    }

    public void TakeShot()
    {
        Bullet bullet = Instantiate(_bulletPrefab, _shootPoint.position, Quaternion.identity);
        bullet.Launch(Vector3.forward);
    }
}
