using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaManagér : MonoBehaviour
{
    GameObject Frog;
    void Start()
    {
        if (GameObject.Find("Frog"))
        {
            Frog = GameObject.Find("Frog");
        }
    }
    void Update()
    {
        if (!Frog&&Input.anyKey) 
        {
            CEO_Bob_Bobson.ceo.YouKindaBadTho();
        }   
    }
}
