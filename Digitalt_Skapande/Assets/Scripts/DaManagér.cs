using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DaManagér : MonoBehaviour
{
    public int levelID;
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            goBack();
            return;
        }
        if (!Frog&&Input.anyKey) 
        {
            YouKindaBadTho();
        }
        if (GameObject.FindGameObjectsWithTag("bois").Length == 0 && Input.anyKey)
        {
            if (levelID > levelmanager.clearedLevels)
            {
                levelmanager.clearedLevels = levelID;
            }
            
            goBack();
        }
    }
    public void goBack()
    {
        SceneManager.LoadScene("level_select");
    }
    public void YouKindaBadTho()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
