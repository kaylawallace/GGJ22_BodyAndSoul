using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ReusableDialogue : MonoBehaviour
{
    int dialogueSize;
    int currentDialogue;
    bool DialogueTriggered;
    //Class stores all dialogue values
    [SerializeField] DialogueClass[] Dialogue;

    //UI Elements
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject NameBox;
    [SerializeField] GameObject DialogueBox;
    [SerializeField] GameObject Character;

    //players
    [SerializeField] GameObject Soul;
    [SerializeField] GameObject Body;

   

    //UI components
    Image PanelImage;
    Image CharacterImage;
    Text NameText;
    Text DialogueText;

    //player input
    PlayerControls input;

    //functions handling input
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
        PanelImage = Panel.GetComponent<Image>();
        CharacterImage = Character.GetComponent<Image>();
        NameText = NameBox.GetComponent<Text>();
        DialogueText = DialogueBox.GetComponent<Text>();
        currentDialogue = 0;
        Character.SetActive(false);
        DialogueTriggered = false;
        
    }
    

    

    //Updates Dialogue based on input
    void NextDialogue()
    {
        if(DialogueTriggered)
        {
            currentDialogue++;
            if (currentDialogue < dialogueSize)
            {                
                SetDialogueValues();
            }
            else
            {
                DisableDialogueUI();
                Body.GetComponent<BodyController>().enabled = true;
                Soul.GetComponent<SoulController>().enabled = true;
                Debug.Log(gameObject.name);
                DialogueTriggered = false;
                GetComponent<Collider>().enabled = false;
            }
        }
        
    }

    //Disables UI Elements
    void DisableDialogueUI()
    {
        Panel.SetActive(false);
        Character.SetActive(false);
        DialogueBox.SetActive(false);
        NameBox.SetActive(false);
    }

    //Enables UI
    void ActivateDialogue()
    {
        Panel.SetActive(true);
        Character.SetActive(Dialogue[currentDialogue].hasImage());
        DialogueBox.SetActive(true);
        NameBox.SetActive(true);
    }

    //Setting sprites and text to dialogue
    void SetDialogueValues()
    {
        PanelImage.sprite = Dialogue[currentDialogue].GetPanel();

        if (Dialogue[currentDialogue].hasImage())
        {
            Character.SetActive(true);
            CharacterImage.sprite = Dialogue[currentDialogue].GetCharacter();

        }
        else
        {
            Character.SetActive(false);
        }

        NameText.text = Dialogue[currentDialogue].GetNameText();

        DialogueText.text = "";
        StopAllCoroutines();
        if(DialogueTriggered)
        {
           StartCoroutine(TypeScentence());
        }
    }

    IEnumerator TypeScentence()
    {
        foreach (char letter in Dialogue[currentDialogue].GetDialogueText().ToCharArray())
        {
            DialogueText.text += letter;
            yield return new WaitForSeconds(Dialogue[currentDialogue].GetDialogueSpeed());
        }
    }

    //trigger handle for dialogue
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Body" || other.tag == "Soul")
        {
            //Make player idle
            Body.GetComponent<BodyController>().animController.SetInteger("AnimState", 0);
            Body.GetComponent<BodyController>().enabled = false;
            Soul.GetComponent<SoulController>().enabled = false;
            DialogueTriggered = true;
            SetDialogueValues();
            ActivateDialogue();
        }
    }
}
