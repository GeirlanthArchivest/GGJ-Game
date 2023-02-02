using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject mainMenuUI;
    
    void Start()
    {
        Time.timeScale = 1f;
        FindObjectOfType<AudioManager>().Play("MainTheme");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //score.theScore = 0;
    }

    public void settings()
    {
        settingsMenu.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}