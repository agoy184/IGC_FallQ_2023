using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu SharedInstance;
    
    public void ResumeGame()
    {
        GameManager.Instance.ResumeGame();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
