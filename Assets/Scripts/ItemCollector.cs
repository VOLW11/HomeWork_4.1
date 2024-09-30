using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Transform _targetPoint;

    private ImprovementsAbilities _ability;
    private Item _item;

    private void Awake()
    {
        _ability = GetComponent<ImprovementsAbilities>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_item != null)
            {
                _item.UseEffect(_ability);

                _item = null;
            }
            else
            {
                Debug.Log("У вас нет предметов в инвентаре");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponentInParent<Item>();

        if (item != null)
        {
            if (_item == null)
            {
                item.transform.SetParent(this.transform);

                item.transform.position = _targetPoint.position;

                _item = item;
            }
        }
    }
}
