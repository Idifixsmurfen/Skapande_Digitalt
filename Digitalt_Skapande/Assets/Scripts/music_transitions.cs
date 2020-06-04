using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music_transitions : MonoBehaviour
{
    [SerializeField]
    AudioClip[] clips;
    AudioSource source;
    public int desiredClip;
    void Start()
    {
        source = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex > 1)
        {
            if (GameObject.Find("Frog") != null)
            {
                desiredClip = 1;
                if (GameObject.Find("Frog").GetComponent<Helth>().Hellth <= 1)
                {
                    desiredClip = 2;
                }
            }
            else
            {
                desiredClip = 2;
            }
        }
        else
        {
            desiredClip = 0;
        }
        if (!source.isPlaying)
        {
            source.clip = clips[desiredClip];
            source.Play();
        }
    }
}