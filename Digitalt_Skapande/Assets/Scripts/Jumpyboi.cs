using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Jumpyboi : MonoBehaviour
{
    public Rigidbody2D SkrivEttNamn;//Referens till rigid body
    public float EttNyttNamn;      //Rörelse, upp
    int EttTillNamn;               //Antal hopp
    public LayerMask GeDenEttNamn; //Vad är mark
    public float EttTillNyttNamn;  //Röresle, sidled
    bool InteFacingRight;          //Facing Right
        
    void Start()
    {
        
    }
    void Update()
    {
        flip();
        if (Physics2D.OverlapCircle(new Vector3(0,-1,0)+transform.position,0.2f,GeDenEttNamn)&&SkrivEttNamn.velocity.y<=1)
        {
            EttTillNamn = 2;

        }
        if ((Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.W)) && EttTillNamn>0) 
        {
            SkrivEttNamn.velocity = new Vector2(SkrivEttNamn.velocity.x,EttNyttNamn);
            EttTillNamn--;

        }
        SkrivEttNamn.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * EttTillNyttNamn, SkrivEttNamn.velocity.y);
    }
    void flip()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput > 0 && !InteFacingRight || horizontalInput < -0 && InteFacingRight)
        {
            InteFacingRight = !InteFacingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
