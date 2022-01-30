using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class IntroScript : MonoBehaviour
{
    int dialogueNumber;
    bool fadeComplete;
    [SerializeField] float fadeTime;
    float fadeTimer;
    [SerializeField] GameObject BlackScreen;
    [SerializeField] GameObject body;
    [SerializeField] GameObject soul;
    PlayerControls input;

    // Start is called before the first frame update
    void Start()
    {
        body.GetComponent<BodyController>().enabled = false;
        soul.GetComponent<SoulController>().enabled = false;
        dialogueNumber = 0;
        fadeTime = 6;
        fadeTimer = 0;
        fadeComplete = true;
    }

    private void Awake()
    {
        input = new PlayerControls();

        input.Dialogue.NextDialogue.performed += ctx => NextDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueNumber > 1)
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
        
    }

    void NextDialogue()
    {

    }

    void FirstDialogue()
    {
        
    }
}
