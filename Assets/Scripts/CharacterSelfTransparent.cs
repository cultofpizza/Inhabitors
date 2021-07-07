using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelfTransparent : MonoBehaviour
{
    public Material material;

    private void Awake()
    {
        GameObject[] gameObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject gameObject in gameObjects)
        {
            MeshRenderer meshRenderer;
            gameObject.TryGetComponent<MeshRenderer>(out meshRenderer);
            meshRenderer.material = material;

        }
    }
}
