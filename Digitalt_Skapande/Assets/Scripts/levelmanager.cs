using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelmanager : MonoBehaviour
{
    GameObject[] Levels;
    public static int clearedLevels;
    void Start()
    {
        for (int i = 0; i < clearedLevels; i++)
        {
            Levels[i].SetActive(true);
        }
    }
    void Update()
    {
        
    }
    public void chooseLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
}