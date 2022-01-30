using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum Option
{
    Play,
    Options,
    Exit
}

public class MenuManager : MonoBehaviour
{
    PlayerControls input;
    [SerializeField] GameObject Play;
    [SerializeField] GameObject Options;
    [SerializeField] GameObject Exit;
    [SerializeField] GameObject Transition;
    [SerializeField] Option menuState;
    Color32 selectedColor;
    // Start is called before the first frame update
    void Start()
    {
        selectedColor = new Color32(0xFF, 0xE1, 0x56, 0xFF);
        menuState = Option.Play;
        Play.GetComponent<Image>().color = selectedColor;
    }

    private void Awake()
    {
        input = new PlayerControls();

        input.Menu.Select.performed += ctx => Pressed();

        input.Menu.HighlightUp.performed += ctx => SelectUp();

        input.Menu.HighlightDown.performed += ctx => SelectDown();
    }

    private void OnEnable()
    {
        input.Menu.Enable();
    }

    private void OnDisable()
    {
        input.Menu.Disable();
    }

    private void Pressed()
    {
        switch (menuState)
        {
            case Option.Play:
                Transition.SetActive(true);
                GetComponent<TransitionScript>().activateTransition = true;
                //TODO switch scene
                break;
            case Option.Options:
                //TODO add options
                break;
            case Option.Exit:
                //TODO play sound and close game
                
                break;
        }

    }

    private void SelectUp()
    {
        switch (menuState)
        {
            case Option.Play:
                Play.GetComponent<Image>().color = Color.white;
                Options.GetComponent<Image>().color = Color.white;
                Exit.GetComponent<Image>().color = selectedColor;
                menuState = Option.Exit;
                break;
            case Option.Options:
                Play.GetComponent<Image>().color = selectedColor;
                Options.GetComponent<Image>().color = Color.white;
                Exit.GetComponent<Image>().color = Color.white;
                menuState = Option.Play;
                break;
            case Option.Exit:
                Play.GetComponent<Image>().color = Color.white;
                Options.GetComponent<Image>().color = selectedColor;
                Exit.GetComponent<Image>().color = Color.white;
                menuState = Option.Options;
                break;
        }
    }

    private void SelectDown()
    {
        switch (menuState)
        {
            case Option.Play:
                Play.GetComponent<Image>().color = Color.white;
                Options.GetComponent<Image>().color = selectedColor;
                Exit.GetComponent<Image>().color = Color.white;
                menuState = Option.Options;
                break;
            case Option.Options:
                Play.GetComponent<Image>().color = Color.white;
                Options.GetComponent<Image>().color = Color.white;
                Exit.GetComponent<Image>().color = selectedColor;
                menuState = Option.Exit;
                break;
            case Option.Exit:
                Play.GetComponent<Image>().color = selectedColor;
                Options.GetComponent<Image>().color = Color.white;
                Exit.GetComponent<Image>().color = Color.white;
                menuState = Option.Play;
                break;
        }
    }

    
}
