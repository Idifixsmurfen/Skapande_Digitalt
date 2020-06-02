using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typ_flug_ai_ps_inga_mellanrum : MonoBehaviour
{
    public Rigidbody2D Rigidbodi;//Referens till rigid body
    Transform Kun_coordinates; //player cords
    public float FoV; //field of view
    public float BlueStuff;   //Speed
    Vector2 Where_you_goin; //direction
    float RandomNumber = 0;
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
           
            RandomNumber = 0;
        } 
        else
        {
            Invoke("ChangeDirection", RandomNumber);

        } 
        
        Where_you_goin.Normalize();
        Where_you_goin *= BlueStuff;
        Rigidbodi.velocity = new Vector2(Where_you_goin.x, Where_you_goin.y);
    }
    void ChangeDirection()
    {
        CancelInvoke("ChangeDirection");
        Debug.Log("?");
        RandomNumber = Random.Range(0.5f, 3f);
        Where_you_goin = Random.insideUnitCircle;
    }
}
