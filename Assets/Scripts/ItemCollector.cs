using Unity.VisualScripting;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    private Item _item;
    private bool _isFreeHands = true;

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.F) && _item != null)
        {    
            Destroy(_item);
            _isFreeHands = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponent<Item>();

        if (item != null && _isFreeHands)
        {
            item.transform.SetParent(this.transform);

            _item = item;

            _isFreeHands = false;
        }
    }
}
