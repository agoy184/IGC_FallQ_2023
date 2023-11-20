using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject[] innerMenus;

    private void Awake()
    {
        foreach (GameObject menu in innerMenus) {
            menu.SetActive(false);
        }
    }

    public void PlayGame()
    {
        StartCoroutine(IntroCutscene());
        //SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void ResumeGame()
    {
        GameManager.Instance.ResumeGame();
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        Time.timeScale = 1f;
    }

    private IEnumerator IntroCutscene(){
        if(CinematicBarsController.Instance != null){
             CinematicBarsController.Instance.ShowBars();
            }
        
        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene("ForestScene");
        //cinematicBarsAnimator.SetTrigger("SceneStart");
        //CinematicBarsController.Instance.OpenScene();

    }
}
