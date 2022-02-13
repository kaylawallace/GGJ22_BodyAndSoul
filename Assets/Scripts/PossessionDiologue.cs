using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PossessionDiologue : MonoBehaviour
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
                dialogue.text = "(that’s very dramatic)… I’m not so sure it’s just one world anymore… but, yeah, you are stuck…";
                panelImage.sprite = panelSprites[1];
                //standard
                characterImage.sprite = characterSprites[7];
                characterName.text = "Soul";
                break;
            case 2:
                dialogue.text = "And how would I know, without your sage observations? *SIGH* I have this urge to find a magical solution, but –";
                panelImage.sprite = panelSprites[0];
                //standard
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 3:
                dialogue.text = "Nope. Nothing.";
                panelImage.sprite = panelSprites[0];
                //down
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 4:
                dialogue.text = "hmmmmoooooo…! yes, we were magical, weren’t we…? I might be able to help persuade it to… cooperate…";
                panelImage.sprite = panelSprites[1];
                //thinking
                characterImage.sprite = characterSprites[7];
                characterName.text = "Soul";
                break;
            case 5:
                dialogue.text = "Persuade what? The ledge? Does it have ears that I’m not seeing?";
                panelImage.sprite = panelSprites[0];
                //thinking
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 6:
                dialogue.text = "maybe not ‘ears’, exactly… but I wouldn’t be so quick to judge… maybe if I just got… real close…";
                panelImage.sprite = panelSprites[1];
                //thinking
                characterImage.sprite = characterSprites[7];
                characterName.text = "Soul";
                break;
            case 7:
                dialogue.text = "Soul! Get close to the ledge and press A.";
                panelImage.sprite = panelSprites[1];
                Character.SetActive(false);
                characterName.text = "Hint";
                break;
            case 8:
                dialogue.text = "…Okay, yeah, cool. Are you just stuck in there, though, or…?";
                panelImage.sprite = panelSprites[0];
                //surprise
                Character.SetActive(true);
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 9:
                dialogue.text = "hold on… I’m still getting the hang of all this… oooo, this feels weird…";
                panelImage.sprite = panelSprites[1];
                //thinking
                characterImage.sprite = characterSprites[7];
                characterName.text = "Soul";
                break;
            case 10:
                dialogue.text = "Soul! Move around using your normal movement controls to move the object.";
                panelImage.sprite = panelSprites[1];
                Character.SetActive(false);
                characterName.text = "Hint";
                break;
            case 11:
                dialogue.text = "Oh, okay, now that’s more like it! Watch where you’re going, though, I don’t need my head taken off by a flying lump of rock.";
                panelImage.sprite = panelSprites[0];
                //shock
                Character.SetActive(true);
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 12:
                dialogue.text = "wooooo…! this is very fun… I’m not sure how the ethics shake out, but it’s not really ‘alive’… I think…";
                panelImage.sprite = panelSprites[1];
                //standard
                characterImage.sprite = characterSprites[7];
                characterName.text = "Soul";
                break;
            case 13:
                dialogue.text = "You’re my disembodied-soul, somehow formed into your own sentience - I think we’re already beyond spell ethics. ";
                panelImage.sprite = panelSprites[0];
                //standard
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 14:
                dialogue.text = "Soul! There are many objects you can control this way. Get real snug with anything you want to move, and you’ll see which ones are up for it.";
                panelImage.sprite = panelSprites[1];
                Character.SetActive(false);
                characterName.text = "Hint";
                break;
            case 15:
                dialogue.text = "Y'know... If you can possess things like that - chances are you can move through them too. You're a spirit, after all. ";
                panelImage.sprite = panelSprites[0];
                //thinking
                Character.SetActive(true);
                characterImage.sprite = characterSprites[7];
                characterName.text = "Body";
                break;
            case 16:
                dialogue.text = "oooo... good point...";
                panelImage.sprite = panelSprites[1];
                //standard
                characterImage.sprite = characterSprites[7];
                characterName.text = "Soul";
                break;
            case 17:
                dialogue.text = "Soul! There are many surfaces that aren’t quite as solid for you. Try moving through them – you’ll find you have an easier time getting around.";
                panelImage.sprite = panelSprites[1];
                Character.SetActive(false);
                characterName.text = "Hint";
                break;
            case 18:
                Panel.SetActive(false);
                gameObject.SetActive(false);
                //TODO release player controls
                break;

        }
    }

    void FirstDialogue()
    {
        //body.GetComponent<BodyController>().enabled = false;
        //soul.GetComponent<SoulController>().enabled = false;
        Panel.SetActive(true);
        Character.SetActive(true);
        dialogue.text = "Crap.I can’t get up there – chained, as I seem to be, to the laws of this world.";
        characterName.text = "Body";
        panelImage.sprite = panelSprites[0];
        characterImage.sprite = characterSprites[1];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FirstDialogue();
        }
    }
}

    

