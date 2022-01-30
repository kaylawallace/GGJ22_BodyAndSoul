using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MenuBoardSelection
{
    Resume,
    Options,
    Restart,
    Exit
}

public enum OptionBoardSelection
{
    Music,
    Sound,
    Back
}

public enum PauseBoardSelection
{
    Menu,
    Options
}

public class PauseScript : MonoBehaviour
{
    [SerializeField] GameObject MenuBoard;
    [SerializeField] GameObject OptionsBoard;
    [SerializeField] GameObject ResumeHighlight;
    [SerializeField] GameObject OptionsHighlight;
    [SerializeField] GameObject RestartHighlight;
    [SerializeField] GameObject ExitHighlight;
    [SerializeField] GameObject MusicHighlight;
    [SerializeField] GameObject SoundHighlight;
    [SerializeField] GameObject BackHighlight;
    PlayerControls input;
    float[] soundVolume = new float[2];


    MenuBoardSelection menuSelection;
    OptionBoardSelection optionSelection;
    PauseBoardSelection pauseSelection;

    // Start is called before the first frame update
    void Start()
    {
        menuSelection = MenuBoardSelection.Resume;
        optionSelection = OptionBoardSelection.Music;
        pauseSelection = PauseBoardSelection.Menu;
        OptionsBoard.SetActive(false);
        MenuHighlights();

    }

    private void Awake()
    {
        input= new PlayerControls();

        input.Menu.Select.performed += ctx => Select();
        input.Menu.HighlightDown.performed += ctx => HighlightDown();
        input.Menu.HighlightUp.performed += ctx => HighlightUp();
    }

    private void OnEnable()
    {
        input.Menu.Enable();
    }
    private void OnDisable()
    {
        input.Menu.Disable();
    }

    void HighlightUp()
    {
        Debug.Log("up called");
        Debug.Log(menuSelection);
        if(pauseSelection == PauseBoardSelection.Menu)
        {
            switch(menuSelection)
            {
                case MenuBoardSelection.Resume:
                    ResumeHighlight.SetActive(false);
                    ExitHighlight.SetActive(true);
                    menuSelection = MenuBoardSelection.Exit;
                    break;
                case MenuBoardSelection.Options:
                    OptionsHighlight.SetActive(false);
                    ResumeHighlight.SetActive(true);
                    menuSelection = MenuBoardSelection.Resume;

                    break;
                case MenuBoardSelection.Restart:
                    RestartHighlight.SetActive(false);
                    OptionsHighlight.SetActive(true);
                    menuSelection = MenuBoardSelection.Options;

                    break;
                case MenuBoardSelection.Exit:
                    ExitHighlight.SetActive(false);
                    RestartHighlight.SetActive(true);
                    menuSelection = MenuBoardSelection.Restart;

                    break;
            }
        }
        else
        {
            switch (optionSelection)
            {
                case OptionBoardSelection.Back:
                    BackHighlight.SetActive(false);
                    //TODO make Sound slider highlighted
                    optionSelection = OptionBoardSelection.Sound;
                    break;
                case OptionBoardSelection.Sound:
                    //TODO unhiglight SLider and make music slider highlighted
                    optionSelection = OptionBoardSelection.Music;
                    break;
                case OptionBoardSelection.Music:
                    //TODO unhighlight music slider
                    BackHighlight.SetActive(true);
                    optionSelection = OptionBoardSelection.Back;
                    break;
            }

        }
    }

    void HighlightDown()
    {
        if (pauseSelection == PauseBoardSelection.Menu)
        {
            switch (menuSelection)
            {
                case MenuBoardSelection.Resume:
                    ResumeHighlight.SetActive(false);
                    OptionsHighlight.SetActive(true);
                    menuSelection = MenuBoardSelection.Options;
                    break;
                case MenuBoardSelection.Options:
                    OptionsHighlight.SetActive(false);
                    RestartHighlight.SetActive(true);
                    menuSelection = MenuBoardSelection.Restart;
                    break;
                case MenuBoardSelection.Restart:
                    RestartHighlight.SetActive(false);
                    ExitHighlight.SetActive(true);
                    menuSelection = MenuBoardSelection.Exit;
                    break;
                case MenuBoardSelection.Exit:
                    ExitHighlight.SetActive(false);
                    ResumeHighlight.SetActive(true);
                    menuSelection = MenuBoardSelection.Resume;
                    break;
            }
        }
        else
        {
            switch (optionSelection)
            {
                case OptionBoardSelection.Back:
                    BackHighlight.SetActive(false);
                    optionSelection = OptionBoardSelection.Music;
                    //TODO Highlight Music Slider
                    break;
                case OptionBoardSelection.Sound:
                    //TODO unhighlight sound slider
                    BackHighlight.SetActive(true);
                    optionSelection = OptionBoardSelection.Back;
                    break;
                case OptionBoardSelection.Music:
                    //TODO Unhighlight music slider
                    //TODO highlight sound slider
                    optionSelection = OptionBoardSelection.Sound;
                    break;
            }

        }
    }

    private void Select()
    {
        if (pauseSelection == PauseBoardSelection.Menu)
        {
            switch (menuSelection)
            {
                case MenuBoardSelection.Resume:
                    //Todo Close Pause
                    break;
                case MenuBoardSelection.Options:
                    pauseSelection = PauseBoardSelection.Options;
                    MenuBoard.SetActive(false);
                    menuSelection = MenuBoardSelection.Resume;
                    OptionsBoard.SetActive(true);
                    break;
                case MenuBoardSelection.Restart:
                    //TODO reset scene
                    break;
                case MenuBoardSelection.Exit:
                    //TODO set to main menu
                    break;
            }
        }
        else
        {
            switch (optionSelection)
            {
                case OptionBoardSelection.Back:
                    pauseSelection = PauseBoardSelection.Menu;
                    optionSelection = OptionBoardSelection.Music;
                    OptionsBoard.SetActive(false);
                    MenuBoard.SetActive(true);
                    MenuHighlights();
                    break;
            }

        }
    }

    void MenuHighlights()
    {
        ResumeHighlight.SetActive(true);
        OptionsHighlight.SetActive(false);
        RestartHighlight.SetActive(false);
        ExitHighlight.SetActive(false);
        BackHighlight.SetActive(false);
    }

}
