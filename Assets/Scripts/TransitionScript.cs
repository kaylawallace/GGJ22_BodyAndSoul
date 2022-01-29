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
    // Start is called before the first frame update
    void Start()
    {
        Transition.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transitionTimer += Time.deltaTime;
        if(transitionTimer < transitionTime)
        {
            Transition.transform.localScale += Transition.transform.localScale *  (transitionSpeed * Time.deltaTime);
        }
        else
        {
            Transition.transform.localScale -= Transition.transform.localScale * (transitionSpeed * Time.deltaTime);
        }
    }
}
