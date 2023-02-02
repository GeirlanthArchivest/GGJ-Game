using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winMenu : MonoBehaviour
{
    public GameObject endMenuUI;

    void OnTriggerEnter()
    {
        Pause();
        FindObjectOfType<AudioManager>().Stop("Theme");
        FindObjectOfType<AudioManager>().Play("WinTheme");
    }
    
    void Pause()
    {
        endMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
