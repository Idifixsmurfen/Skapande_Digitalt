using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    [SerializeField]
    Sprite[] sprites;
    Image image;
    Helth frogHealth;
    void Start()
    {
        if (GameObject.Find("Frog"))
        {
            frogHealth = GameObject.Find("Frog").GetComponent<Helth>();
        }
        image = GetComponent<Image>();
    }
    void Update()
    {
        if (frogHealth)
        {
            image.sprite = sprites[frogHealth.Hellth];
        }
    }
}
