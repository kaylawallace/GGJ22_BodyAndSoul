using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    [SerializeField] AK.Wwise.Event bgmusic;
    // Start is called before the first frame update
    void Start()
    {
        bgmusic.Post(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
