using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class IntroScript : MonoBehaviour
{
    int dialogueNumber;
    bool fadeComplete;
    bool soulWalk;
    bool bodyWalk;
    [SerializeField] float fadeTime;
    float fadeTimer;
    [SerializeField] GameObject BlackScreen;
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
        //body.GetComponent<BodyController>().enabled = false;
        //soul.GetComponent<SoulController>().enabled = false;
        dialogueNumber = 0;
        fadeTime = 6;
        fadeTimer = 0;
        fadeComplete = true;
        panelImage = Panel.GetComponent<Image>();
        characterImage = Character.GetComponent<Image>();
        dialogue = dialogueText.GetComponent<Text>();
        characterName = NameText.GetComponent<Text>();
        FirstDialogue();
        bodyWalk = false;
        soulWalk = false;
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

    // Update is called once per frame
    void Update()
    {
        if(dialogueNumber == 1 && !fadeComplete)
        {
            fadeTimer += Time.deltaTime;
            if(fadeTimer < fadeTime)
            {
                BlackScreen.GetComponent<Image>().color = new Color(1, 1, 1, 1 - (fadeTimer / fadeTime));
            }
            else
            {
                BlackScreen.SetActive(false);
                fadeComplete = true;
            }
        }

        if (bodyWalk)
        {
            //TODO Move Body
        }

        if(soulWalk)
        {
            //TODO move soul
        }
        
    }

    void NextDialogue()
    {
        if(fadeComplete)
        {

            dialogueNumber++;
            switch (dialogueNumber)
            {
                case 1:
                    panelImage.sprite = panelSprites[1];
                    dialogue.text = "oooowwww…";
                    fadeComplete = false;
                    break;
                case 2:
                    dialogue.text = "Who - what - the hell are you?!";
                    panelImage.sprite = panelSprites[0];
                    Character.SetActive(true);
                    characterImage.sprite = characterSprites[3];
                    characterName.text = "Body";
                    break;
                case 3:
                    dialogue.text = "I – am you…? or you’re me... oooooo, this is interesting…!";
                    panelImage.sprite = panelSprites[1];
                    characterImage.sprite = characterSprites[6];
                    characterName.text = "Soul";
                    break;
                case 4:
                    dialogue.text = "What… where are we? I remember… wow, I don’t remember anything.";
                    panelImage.sprite = panelSprites[0];
                    characterImage.sprite = characterSprites[1];
                    characterName.text = "Body";
                    break;
                case 5:
                    dialogue.text = "this place is amazing…! and it looks like - are you my body…? which would make me – the rest…? what’s left without the body...?";
                    panelImage.sprite = panelSprites[1];
                    characterImage.sprite = characterSprites[9];
                    characterName.text = "Soul";
                    break;
                case 6:
                    dialogue.text = "There must be someone around who can explain. If I find out who ‘ported me without asking…";
                    panelImage.sprite = panelSprites[0];
                    characterImage.sprite = characterSprites[0];
                    characterName.text = "Body";
                    bodyWalk = true;
                    break;
                case 7:
                    dialogue.text = "w-wait, where are you going…? don’t leave me here, I’m you – I mean, you’re me – wait, WAIT…";
                    panelImage.sprite = panelSprites[1];
                    characterImage.sprite = characterSprites[7];
                    characterName.text = "Soul";
                    soulWalk = true;
                    break;
                case 8:
                    //TODO set Locations to start
                    //TODO transition camera to new location.
                    gameObject.SetActive(false);
                    Panel.SetActive(false);
                    Character.SetActive(false);
                    break;


            }
        }
    }

    void FirstDialogue()
    {
        Panel.SetActive(true);
        dialogueText.SetActive(true);
        Character.SetActive(false);

        panelImage.sprite = panelSprites[0];

        characterName.text = "???";
        dialogue.text = "Ughhhhh…";

    }


}
