using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private Transform _prefabItem;
    private Transform _targetPoint;

    private void Awake()
    {
        _targetPoint = GetComponent<Transform>();

        Instantiate(_prefabItem, _targetPoint.position, Quaternion.identity);
    }

}
