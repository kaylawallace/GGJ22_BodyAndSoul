using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterSwitcher : MonoBehaviour
{
    //public static CharacterSwitcher instance;
    int index = 0;
    public List<GameObject> players = new List<GameObject>();
    [SerializeField] PlayerInputManager manager;
    
    public void SwitchCharacter(PlayerInput input)
    {
        index = 1;
        manager.playerPrefab = players[index];
    }
}
