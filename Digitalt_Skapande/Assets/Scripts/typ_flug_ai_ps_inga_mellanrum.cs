using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class typ_flug_ai_ps_inga_mellanrum : MonoBehaviour
{
    Rigidbody2D thisRB;
    Transform target;
    AudioSource thisAS;
    Helth YouDeadYet;

    public float LaunchFly;
    public float LaunchFrog;
    public float vision; 
    public float baseSpeed; 

    Vector2 direction;
    float RandomNumber = 0;
    bool FacingRight = true;
    void Start()
    {
        thisRB = GetComponent<Rigidbody2D>();
        thisAS = GetComponent<AudioSource>();
        YouDeadYet = GetComponent<Helth>();
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Vector2 SchmackPosition = collision.GetContact(0).point;
            Vector2 Direction =(Vector2) transform.position - SchmackPosition;
            Direction.Normalize();
            Direction *= LaunchFly;
            thisRB.velocity = Direction;
            if (SchmackPosition.y -0.2f> transform.position.y) //;
            {
                YouDeadYet.Hellth--;
                collision.gameObject.GetComponent<Rigidbody2D>().velocity=new Vector2(collision.gameObject.GetComponent<Rigidbody2D>().velocity.x,LaunchFrog) ;

            }
            else //()
            {
                collision.gameObject.GetComponent<Helth>().Hellth--;
                
            }

        }
    }

}
