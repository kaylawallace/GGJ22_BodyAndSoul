using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class DialogueClass
{
    [SerializeField] bool hasCharacterImage;
    
    [TextArea(3,10)]
    [SerializeField] string DialogueText;
    
    [SerializeField] string NameText;
    [SerializeField] Sprite PanelSprite;
    [SerializeField] Sprite CharacterSprite;
    [SerializeField] float DialogueTime;

    public bool hasImage() { return hasCharacterImage; }

    public Sprite GetPanel() { return PanelSprite; }

    public Sprite GetCharacter() { return CharacterSprite; }

    public string GetDialogueText() { return DialogueText; }

    public string GetNameText() { return NameText; }

    public float GetDialogueSpeed() { return DialogueTime; }
}
