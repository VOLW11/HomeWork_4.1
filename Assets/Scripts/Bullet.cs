using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _explosionPrefab;

    public void Launch(Vector3 direction)
    {
        _rigidbody.AddForce(direction * _force, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];

        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;

        Instantiate(_explosionPrefab, position, rotation);
        Destroy(gameObject);
    }
}
