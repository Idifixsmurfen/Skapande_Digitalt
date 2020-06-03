using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CEO_Bob_Bobson : MonoBehaviour
{
    public static void ChangePlaces(string scenename) 
    {
        SceneManager.LoadScene(scenename);

    }
    public static void YouKindaBadTho()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}