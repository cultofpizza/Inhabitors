using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject prefab;
    public InventoryObject inventory;

    public Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    public InventoryCell[] cells;

    private void Start()
    {
        inventoryPanel = GameObject.FindGameObjectWithTag("InventoryPanel");

        CreateSlots();
        inventory.Refresh += UpdateDisplay;
    }

    public void CreateSlots()
    {
        new Dictionary<InventorySlot, GameObject>();




        cells = inventoryPanel.GetComponentsInChildren<InventoryCell>();

        for (int i = 0; i < inventory.Container.Items.Count; i++)
        {
            AddItem(i);
        }
    }

    public void UpdateDisplay()
    {
        for (int i = 0; i < inventory.Container.Items.Count; i++)
        {
            if (itemsDisplayed.ContainsKey(inventory.Container.Items[i]))
            {
                itemsDisplayed[inventory.Container.Items[i]].GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container.Items[i].amount.ToString();
            }
            else
            {
                AddItem(i);
            }

        }
    }

    private void AddItem(int i)
    {     
        var obj = Instantiate(prefab, cells[i].transform.position, Quaternion.identity, cells[i].transform);
        obj.transform.GetComponentInChildren<Image>().sprite = inventory.database.GetItem[inventory.Container.Items[i].item.Id].uiSprite;        
        obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container.Items[i].amount.ToString();
        itemsDisplayed.Add(inventory.Container.Items[i], obj);
    }
}
