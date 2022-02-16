using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineRender : MonoBehaviour
{
    public Color c1 = Color.yellow;
    public Color c2 = Color.red;
    public int len = 2;
    public GameObject soul;
    public Transform bodyPos, soulPos;
    public LineRenderer line;
    public float posOffset;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!bodyPos)
        {
            bodyPos = GameObject.FindGameObjectWithTag("Body").transform;
        }
        if (!soulPos)
        {
            soul = GameObject.Find("Soul");
            soulPos = GameObject.FindGameObjectWithTag("Soul").transform;
        }

        if (!line)
        {
            line = gameObject.GetComponent<LineRenderer>();
            line.widthMultiplier = .6f;
            line.positionCount = 2;
        }

        float alpha = 1f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(c1, 0f), new GradientColorKey(c2, 1f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0f), new GradientAlphaKey(alpha, 1f) }
            );
        line.colorGradient = gradient;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!line)
        {
            line = gameObject.GetComponent<LineRenderer>();
        }

        if (!bodyPos)
        {
            bodyPos = GameObject.FindGameObjectWithTag("Body").transform;
        }
        if (!soulPos)
        {
            soulPos = GameObject.FindGameObjectWithTag("Soul").transform;
        }

        var points = new Vector3[2];
        points[0] = new Vector3(bodyPos.position.x, bodyPos.position.y, bodyPos.position.z);

        if (soul.GetComponent<SoulController>().possessing)
        {
            Platform platform = soul.GetComponentInChildren<Platform>();
            Vector3 center = platform.GetComponentInChildren<Transform>().position;
            points[1] = new Vector3(center.x, center.y + posOffset, 0);
        }
        else
        {
            points[1] = new Vector3(soulPos.position.x, soulPos.position.y, soulPos.position.z);
        }

        line.SetPositions(points);
    }
}
