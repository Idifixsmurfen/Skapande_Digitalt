using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud_generator : MonoBehaviour
{
    [SerializeField]
    GameObject cloud;
    [SerializeField]
    float cloudRate;
    void Start()
    {
        makeHappyLittleCloud();
        fillSky();
    }
    void Update()
    {
        
    }
    void makeHappyLittleCloud()
    {
        Vector2 startPosition;
        startPosition.x = -10;
        startPosition.y = Random.Range(-1f, 6f);
        Transform newCloud = Instantiate(cloud, transform.position, Quaternion.identity).transform;
        newCloud.parent = transform;
        newCloud.localPosition = startPosition;
        Invoke("makeHappyLittleCloud", Random.Range(1f, cloudRate));
    }
    void fillSky()
    {
        int i = 0;
        while (i < 50)
        {
            Vector2 startPosition;
            startPosition.x = Random.Range(-11f, 11f); ;
            startPosition.y = Mathf.Pow(Random.Range(0, 3f),2) - 3;
            Transform newCloud = Instantiate(cloud, transform.position, Quaternion.identity).transform;
            newCloud.parent = transform;
            newCloud.localPosition = startPosition; 
            i++;
        }
    }
}
