using Unity.VisualScripting;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Transform _targetPoint;

    private Item _item;
    private bool _isFreeHands = true;

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.F) && _item != null)
        {
            _item.UseEffect();
            
            _isFreeHands = true;
        }

        if (Input.GetKeyDown(KeyCode.F) && _item == null)
            Debug.Log("У вас нет подобранных предметов");
    }

    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponentInParent<Item>();

        if (item != null && _isFreeHands)
        {
            item.transform.SetParent(this.transform);

            item.transform.position = _targetPoint.position;

            _item = item;

            _isFreeHands = false;       
        }
    }
}
