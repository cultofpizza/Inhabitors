using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceType
{
    Default,
    Stone,
    Wood,
    Aluminium,
    Gold,
    Gas
}
public abstract class ResourceWellObject : ScriptableObject
{

    public GameObject prefab;
    public ResourceType type;
    [TextArea(1, 1)]
    public new string name;
    [TextArea(5, 10)]
    public string description;

}
