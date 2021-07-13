using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayableCharactersManager : MonoBehaviour
{
    public static PlayableCharactersManager Singleton;
    public List<PlayableCharacter> characters;
    public int activeId;

    private DefaultInput _defaultInput;


    private void Awake()
    {
        Singleton = this;

        _defaultInput = new DefaultInput();
        BindInput();

        _defaultInput.Enable();


        for (int i = 0; i < characters.Count; i++)
        {
            if (i == 0)
            {
                Activate(i);
                continue;
            }
            Deactivate(i);
        }
    }

    private void BindInput()
    {
        _defaultInput.Character.SwitchCharacter.performed += e => SwitchCharacter();
    }

    private void SwitchCharacter()
    {
        Deactivate(activeId);

        ScrollActive();

        Activate(activeId);
    }

    private void ScrollActive()
    {
        if (activeId == characters.Count - 1)
        {
            activeId = 0;
        }
        else
        {
            activeId += 1;
        }
    }


    private void Activate(int index)
    {
        characters[index].gameObject.SetActive(true);

        characters[index].gameObject.GetComponent<CharacterMovement>().enabled = true;
        characters[index].gameObject.GetComponent<CharacterView>().enabled = true;
        characters[index].gameObject.GetComponent<DisplayInventory>().enabled = true;

        characters[index].gameObject.GetComponentInChildren<Camera>().enabled = true;
        characters[index].gameObject.GetComponentInChildren<AudioListener>().enabled = true;
    }

    private void Deactivate(int index)
    {
        characters[index].gameObject.GetComponent<CharacterMovement>().enabled = false;
        characters[index].gameObject.GetComponent<CharacterView>().enabled = false;
        characters[index].gameObject.GetComponent<DisplayInventory>().enabled = false;

        characters[index].gameObject.GetComponentInChildren<Camera>().enabled = false;
        characters[index].gameObject.GetComponentInChildren<AudioListener>().enabled = false;

        //foreach (var item in characters[index].gameObject.GetComponentInChildren<CharacterMesh>().gameObject.GetComponentsInChildren<Transform>())
        //{
        //    item.gameObject.SetActive(true);
        //}
    }
}
