using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSwitch : MonoBehaviour
{
    private PlayableCharacter playableCharacter;
    
    private void Awake()
    {
        playableCharacter = GetComponent<PlayableCharacter>();
    }

    
}
