using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_tracking_sponsored_by_NSA : MonoBehaviour
{
    Transform PlayerTransform;
    public Vector3 offset;
    public float smoothness;
    void Start()
    {
        if (GameObject.Find("Frog"))
        {
            PlayerTransform = GameObject.Find("Frog").transform;
        }
    }
    void LateUpdate()
    {
        if (PlayerTransform)
        {
            Vector3 clay = PlayerTransform.position + offset;
            Vector3 smoothedClay = Vector3.Lerp(transform.position, clay, smoothness * Time.deltaTime);
            transform.position = smoothedClay;
        }
    }
}