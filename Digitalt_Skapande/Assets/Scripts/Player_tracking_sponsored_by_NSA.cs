using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_tracking_sponsored_by_NSA : MonoBehaviour
{
    Transform PlayerTransform;
    void Start()
    {
     PlayerTransform = GameObject.Find("Frog").transform;
    }


    void Update()
    {
        Vector3 Clay = transform.position + new Vector3(0, 0, 10) ;  //Kamera som ändras

        Clay = Vector3.Lerp(Clay, PlayerTransform.position, 0.15f);
        Clay += new Vector3(0, 0, -10);
        transform.position = Clay;
    }
}
