using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public GameObject cam;
    public float parallax;

    private float len, startPos;
  
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        len = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float dist = cam.transform.position.x * parallax;
        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);
    }
}
