using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music_transitions : MonoBehaviour
{
    [SerializeField]
    AudioClip[] clips;
    AudioSource source;
    public int desiredMusic;
    void Awake()
    {
        source = GetComponent<AudioSource>();
        InvokeRepeating("transition", 5.647f, 5.647f);
    }
    void Update()
    {
       
    }
    void transition()
    {
        if (source.clip != clips[desiredMusic])
        {
            source.clip = clips[desiredMusic];
            source.Play();
        }
    }
}