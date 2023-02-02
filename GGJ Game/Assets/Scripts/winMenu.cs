using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winMenu : MonoBehaviour
{
    public GameObject endMenuUI;

    void OnTriggerEnter()
    {
        Pause();
    }
    
    void Pause()
    {
        endMenuUI.SetActive(true);
        Time.timeScale = 0f;
        
    }
}
