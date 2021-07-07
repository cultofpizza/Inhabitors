using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    public InventoryObject inventory;
    private DisplayInventory display;

    private void Awake()
    {
        display = GetComponent<DisplayInventory>();
    }

    private void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<PickableItem>();
        
        if (item)
        {
            inventory.AddItem(new InventoryItem(item.item), item.amount);
            display.UpdateDisplay();
            Destroy(other.gameObject);
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Container.Items.Clear();
    }
}
