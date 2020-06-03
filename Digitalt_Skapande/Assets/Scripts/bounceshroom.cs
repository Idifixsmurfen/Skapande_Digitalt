using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounceshroom : MonoBehaviour
{
    [SerializeField]
    float bounce;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 SchmackPosition = collision.transform.position;
        Vector2 Direction = SchmackPosition - (Vector2)transform.position;
        Direction.Normalize();
        Direction *= bounce;
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Direction;
    }
}
