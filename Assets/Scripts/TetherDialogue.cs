using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class TetherDialogue : MonoBehaviour
{
    int dialogueNumber;
    [SerializeField] GameObject body;
    [SerializeField] GameObject soul;
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject NameText;
    [SerializeField] GameObject dialogueText;
    [SerializeField] GameObject Character;
    [SerializeField] Sprite[] panelSprites = new Sprite[2];
    [SerializeField] Sprite[] characterSprites = new Sprite[10];
    Image panelImage;
    Image characterImage;
    Text dialogue;
    Text characterName;

    PlayerControls input;

    // Start is called before the first frame update
    void Start()
    {
        
        dialogueNumber = 0;
        panelImage = Panel.GetComponent<Image>();
        characterImage = Character.GetComponent<Image>();
        dialogue = dialogueText.GetComponent<Text>();
        characterName = NameText.GetComponent<Text>();
    }

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

    void NextDialogue()
    {

        dialogueNumber++;
        switch (dialogueNumber)
        {
            case 1:
                dialogue.text = "looks like it… this ‘thing’ between us seems pretty non-negotiable… I get the feeling breaking it wouldn’t end well…";
                characterName.text = "Soul";
                panelImage.sprite = panelSprites[1];
                //thinking
                characterImage.sprite = characterSprites[0];
                break;
            case 2:
                dialogue.text = "Hm. It certainly feels – strong. Let’s test it.";
                characterName.text = "Body";
                panelImage.sprite = panelSprites[0];
                //thinking
                characterImage.sprite = characterSprites[0];
                break;
            case 3:
                dialogue.text = "Body and Soul! Try moving away from one another.";
                panelImage.sprite = panelSprites[1];
                Character.SetActive(false);
                characterName.text = "Hint";
                break;
            case 4:
                dialogue.text = "oooooooOOOWWW!";
                Character.SetActive(true);
                panelImage.sprite = panelSprites[0];
                //Panic
                characterImage.sprite = characterSprites[1];
                characterName.text = "Body";
                break;
            case 5:
                dialogue.text = "oooooooOOOWWW!";
                panelImage.sprite = panelSprites[1];
                //Panic
                characterImage.sprite = characterSprites[9];
                characterName.text = "Soul";
                break;
            case 6:
                dialogue.text = "Yep, okay. Let’s not do that again.";
                panelImage.sprite = panelSprites[0];
                characterImage.sprite = characterSprites[0];
                characterName.text = "Body";
                break;
            case 7:
                dialogue.text = "I don’t feel much of anything… and that’s, y’know, generally weird… but I definitely felt that…";
                panelImage.sprite = panelSprites[1];
                //Panic
                characterImage.sprite = characterSprites[7];
                characterName.text = "Soul";
                break;
            case 8:
                Character.SetActive(false);
                Panel.SetActive(false);
                gameObject.SetActive(false);
                //TODO Release Player Controls
                break;

        }
    }

    void FirstDialogue()
    {
        //body.GetComponent<BodyController>().enabled = false;
        //soul.GetComponent<SoulController>().enabled = false;
        Panel.SetActive(true);
        Character.SetActive(true);
        dialogue.text = "So, am I stuck with you? How delightful.";
        characterName.text = "Body";
        panelImage.sprite = panelSprites[0];
        characterImage.sprite = characterSprites[0];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FirstDialogue();
        }
    }
}
