using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typ_flug_ai_ps_inga_mellanrum : MonoBehaviour
{
    Rigidbody2D thisRB;
    Transform target;
    AudioSource thisAS;

    public float vision; 
    public float baseSpeed; 

    Vector2 direction;
    float RandomNumber = 0;
    bool FacingRight = true;
    void Start()
    {
        thisRB = GetComponent<Rigidbody2D>();
        thisAS = GetComponent<AudioSource>();
        Invoke("enableAnim",Random.Range(0,0.5f));
        if (GameObject.Find("Frog"))
        {
            target = GameObject.Find("Frog").transform;
        } 
    }
    void Update()
    {
        float speed = baseSpeed;
        float distanceToTarget = Vector2.Distance(transform.position, target.position);
        if (target)
        {
            if (distanceToTarget < vision)
            {
                direction = target.position - transform.position;
                speed *= 1.7f;
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
        thisAS.volume = 1 / distanceToTarget;
        direction.Normalize();
        direction *= baseSpeed;
        thisRB.AddForce(direction * speed * Time.deltaTime);
        thisRB.AddTorque(-transform.rotation.z / 2f);
        flip();
    }
    void ChangeDirection()
    {
        CancelInvoke("ChangeDirection");
        RandomNumber = Random.Range(0f, 1f);
        direction = Random.insideUnitCircle;
    }
    void flip()
    {
        float horizontalInput = thisRB.velocity.x;
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
