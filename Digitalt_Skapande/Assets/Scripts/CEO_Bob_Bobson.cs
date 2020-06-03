using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CEO_Bob_Bobson : MonoBehaviour
{
    public static CEO_Bob_Bobson ceo;
    private void Awake()
    {
        ceo = this;
    }
    public void ChangePlaces(string scenename) 
    {
        SceneManager.LoadScene(scenename);
    }
    public void YouKindaBadTho()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quit()
    {
        Application.Quit();
    }
}