using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typ_flug_ai_ps_inga_mellanrum : MonoBehaviour
{
    public Rigidbody2D Rigidbodi;//Referens till rigid body
    Transform Kun_coordinates; //player cords
    public float FoV; //field of view
    Vector2 Where_you_goin; //direction
    void Start()
    {
        Kun_coordinates = GameObject.Find("Frog").transform;
    }

    // Update is called once per frame
    void Update()

    {
        if (Vector2.Distance(transform.position, Kun_coordinates.position) < FoV) 
        {
            Where_you_goin = Kun_coordinates.position - transform.position;
            Where_you_goin.Normalize();
        } 
        
        Rigidbodi.velocity = new Vector2(Where_you_goin.x, Where_you_goin.y);
    }
}
