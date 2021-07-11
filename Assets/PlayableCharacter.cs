using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableCharacter : MonoBehaviour
{
    public PlayableCharactersManager manager;

    private DefaultInput input;
    private int index = 0;

    private void Awake()
    {
        manager.characters.Add(this);
        index = manager.characters.Count - 1;

        // Deactivate();
    }

    private void Activate()
    {
        gameObject.SetActive(true);

    }

    private void Deactivate()
    {
        gameObject.SetActive(false);

    }
}
