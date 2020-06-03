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
    bool FacingRight = true;
    void Start()
    {
        Invoke("enableAnim",Random.Range(0,0.5f));
        if (GameObject.Find("Frog"))
        {
            Kun_coordinates = GameObject.Find("Frog").transform;
        } 
    }
    void Update()
    {
        float speed = BlueStuff;
        if (Kun_coordinates)
        {
            if (Vector2.Distance(transform.position, Kun_coordinates.position) < FoV)
            {
                Where_you_goin = Kun_coordinates.position - transform.position;
                speed *= 2;
                RandomNumber = 0;
            }
            else
            {
                Invoke("ChangeDirection", RandomNumber);
            }
        }
        else
        {
            Invoke("ChangeDirection", RandomNumber);
        } 
        Where_you_goin.Normalize();
        Where_you_goin *= BlueStuff;
        Rigidbodi.AddForce(Where_you_goin * speed * Time.deltaTime);
        Rigidbodi.AddTorque(-transform.rotation.z / 2f);
        flip();
    }
    void ChangeDirection()
    {
        CancelInvoke("ChangeDirection");
        RandomNumber = Random.Range(0f, 1f);
        Where_you_goin = Random.insideUnitCircle;
    }
    void flip()
    {
        float horizontalInput = Rigidbodi.velocity.x;
        if (horizontalInput > 0f && !FacingRight || horizontalInput < -0f && FacingRight)
        {
            FacingRight = !FacingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
    void enableAnim()
    {
        GetComponent<Animator>().enabled = true;
    }
}
