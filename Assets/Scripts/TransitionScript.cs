using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionScript : MonoBehaviour
{
    [SerializeField] GameObject Transition;
    [SerializeField] GameObject NewPosition;
    [SerializeField] float transitionTime;
    [SerializeField] float transitionSpeed;
    float transitionTimer;
    public bool activateTransition;

    
    void Start()
    {
        Transition.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(activateTransition)
        {

            transitionTimer += Time.deltaTime;
            if(transitionTimer < transitionTime)
            {
                Transition.GetComponent<RectTransform>().sizeDelta += Transition.GetComponent<RectTransform>().sizeDelta * (transitionSpeed * Time.deltaTime) ;
            }
            else
            {
                Transition.GetComponent<RectTransform>().sizeDelta -= Transition.GetComponent<RectTransform>().sizeDelta * (transitionSpeed * Time.deltaTime);
            }

            if (transitionTimer > transitionTime)
            {
                //Switch Scene;
            }
        }

    }

    public void EnableTransition()
    {
        activateTransition = true;
    }
}

