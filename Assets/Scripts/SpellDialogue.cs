using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class SpellDialogue : MonoBehaviour
{
    int dialogueNumber;
    [SerializeField] GameObject body;
    [SerializeField] GameObject soul;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject Panel;
    [SerializeField] GameObject NameText;
    [SerializeField] GameObject dialogueText;
    [SerializeField] GameObject Character;
    [SerializeField] Sprite[] panelSprites = new Sprite[3];
    [SerializeField] Sprite[] characterSprites = new Sprite[11];
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
                dialogue.text = "They look like they’re lost. ";
                panelImage.sprite = panelSprites[0];
                //thinking
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 2:
                dialogue.text = "Hey! What’s happened around here? Can you help us?";
                panelImage.sprite = panelSprites[0];
                //shocked
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 3:
                dialogue.text = "Where? Hmmm… I can’t – no! I won’t…";
                panelImage.sprite = panelSprites[0];
                characterImage.sprite = characterSprites[10];
                characterName.text = "Enemy";
                break;
            case 4:
                dialogue.text = "poor thing… I hope you don’t end up like that…";
                panelImage.sprite = panelSprites[1];
                //surprised
                characterImage.sprite = characterSprites[7];
                characterName.text = "Soul";
                break;
            case 5:
                dialogue.text = "I’m not planning on it, trust me. Now, if they can’t hear us, we need to be careful. Don’t want any trouble if we can help it.";
                panelImage.sprite = panelSprites[0];
                //thinking
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 6:
                dialogue.text = "agreed… though I don’t think they can hurt me… so, uh, yeah, be careful…";
                panelImage.sprite = panelSprites[1];
                //surprised
                characterImage.sprite = characterSprites[7];
                characterName.text = "Soul";
                break;
            case 7:
                dialogue.text = "Hey there – we don’t want to hurt you. Could we just get past? We’ll be on our way, no trouble at all.";
                panelImage.sprite = panelSprites[0];
                //standard
                characterImage.sprite = characterSprites[0];
                characterName.text = "Body";
                break;
            case 8:
                dialogue.text = "Ughh. Hungry… Where? Where did they go…? This way?";
                panelImage.sprite = panelSprites[0];
                characterImage.sprite = characterSprites[10];
                characterName.text = "Enemy";
                break;
            case 9:
                dialogue.text = "No, please, just let us pass. Come on. Please? I don’t – I really don’t want to – damn, NO!";
                panelImage.sprite = panelSprites[0];
                //panic
                characterImage.sprite = characterSprites[0];
                characterName.text = "Body";
                break;
            case 10:
                dialogue.text = "Body! Press K to defend yourself.";
                panelImage.sprite = panelSprites[1];
                //surprise
                Character.SetActive(false);
                characterName.text = "Hint";
                break;
            case 11:
                //TODO release character controllers
                Panel.SetActive(false);
                gameObject.SetActive(false);
                break;

        }
    }

    void FirstDialogue()
    {
        //body.GetComponent<BodyController>().enabled = false;
        //soul.GetComponent<SoulController>().enabled = false;
        //enemy.GetComponent<SoulController>().enabled = false;
        Panel.SetActive(true);
        Character.SetActive(true);
        dialogue.text = "oooo, they look nasty… something’s not right… shouldn't they have a spirit too…?";
        characterName.text = "Soul";
        panelImage.sprite = panelSprites[1];
        //surprise
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
