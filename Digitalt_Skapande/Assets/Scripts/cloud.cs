using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    [SerializeField]
    Sprite[] cloudSprites;
    SpriteRenderer thisRend;
    float speed;
    void Start()
    {
        thisRend = GetComponent<SpriteRenderer>();
        thisRend.sprite = cloudSprites[Random.Range(0, cloudSprites.Length)];
        if (Random.Range(1,3) == 1)
        {
            thisRend.flipX = true;
        }
        speed = Random.Range(0.3f,1.2f);
        thisRend.sortingOrder = (int)(speed * 1000);
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
        if (transform.localPosition.x > 10)
        {
            Destroy(gameObject);
        }
    }
}
