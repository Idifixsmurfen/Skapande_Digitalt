﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helth : MonoBehaviour
{
    public int Hellth =0;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Hellth <= 0)
        {
            HeavenOrHell();
        }
    }


    void HeavenOrHell()
    {
        Destroy(gameObject);
    }
}
