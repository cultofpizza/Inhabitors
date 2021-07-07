using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Default,
    Resource,
    Tool,
    Weapon,
    Food,
    Relic,
    PowerUp
}

public abstract class ItemObject : ScriptableObject
{
    public int Id;
    public Sprite uiSprite;
    public ItemType type;
    [TextArea(1, 1)]
    public new string name;
    [TextArea(5,10)]
    public string description;
    public int stack;
    public int disassemblyPoints;
}


[System.Serializable]
public class InventoryItem
{
    public string Name;
    public int Id;

    public InventoryItem(ItemObject itemObject)
    {
        Name = itemObject.name;
        Id = itemObject.Id;
    }
}