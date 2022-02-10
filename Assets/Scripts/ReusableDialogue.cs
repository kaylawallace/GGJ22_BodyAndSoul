using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ReusableDialogue : MonoBehaviour
{
    int dialogueSize;
    [SerializeField] DialogueClass[] Dialogue;
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject NameText;
    [SerializeField] GameObject DialogueText;
    [SerializeField] GameObject Character;
    PlayerControls input;

    private void Awake()
    {
        input = new PlayerControls();

        input.Dialogue.NextDialogue.performed += ctx => NextDialogue();
    }

    private void OnEnable()
    {
        input.Dialogue.Enable();
    }

    private void OnDisable()
    {
        input.Dialogue.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        dialogueSize = Dialogue.Length;
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void NextDialogue()
    {

    }
}
