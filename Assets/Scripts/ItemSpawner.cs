using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private Transform _prefabItem;
    private Transform _targetPoint;
    private Transform _prefabOnScene;

    private float _time;
    private float _timeSpawn = 2f;

    private void Awake()
    {
        _targetPoint = GetComponent<Transform>();
    }

    private void Update()
    {
        if (_prefabOnScene == null)
        {
            _time += Time.deltaTime;

            if (_time >= _timeSpawn)
            {
                _prefabOnScene = Instantiate(_prefabItem, _targetPoint.position, Quaternion.identity);

                _time = 0;
            }
        }
    }
}
