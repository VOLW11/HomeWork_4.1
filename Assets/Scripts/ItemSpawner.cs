using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private Transform _prefabItem;

    private void Awake()
    {
        _prefabItem.position = transform.position;
    }
}
