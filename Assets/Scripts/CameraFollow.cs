using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraFollow : MonoBehaviour
{
    public List<Transform> targets = new List<Transform>();
    public Vector3 offset;
    public float smoothTime = .5f;
    public float minZoom = 30f, maxZoom = 20f;
    public float zoomLimiter = 20f;

    private Vector3 vel;
    private GameObject body, soul;
    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();

        body = GameObject.FindGameObjectWithTag("Body");
        soul = GameObject.FindGameObjectWithTag("Soul");
        targets.Add(body.transform);
        targets.Add(soul.transform);
    }

    private void LateUpdate()
    {
        if (!body)
        {
            body = GameObject.FindGameObjectWithTag("Body");
            if (body)
            {
                targets.Add(body.transform);
                print(body.name);
            }           
        }

        if (!soul)
        {
            soul = GameObject.FindGameObjectWithTag("Soul");
            if (soul)
            {
                targets.Add(soul.transform);
                print(soul.name);
            }
        }

        if (targets.Count == 0)
        {
            return;
        }

        Move();
        Zoom();
    }

    private void Move()
    {
        Vector3 centre = GetCentrePoint();

        Vector3 newPos = centre + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPos, ref vel, smoothTime);
    }

    void Zoom()
    {
        float newZoom = Mathf.Lerp(maxZoom, minZoom, GetDistanceBetweenPlayers() / zoomLimiter);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);
    }

    Vector3 GetCentrePoint()
    {
        if (targets.Count == 1)
        {
            return targets[0].position;
        }

        Bounds bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;
    }

    float GetDistanceBetweenPlayers()
    {
        Bounds bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.size.x;
    }
}
