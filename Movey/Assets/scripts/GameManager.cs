using System.Collections;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public float delay;
    bool GameOver = false;
    public GameObject completeLevelUI;
    


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!GameOver)
        {
            
            GameOver = true;
            Invoke("Restart",delay);
        }
    }
    void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
 
}
