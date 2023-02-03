using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("CreditsTheme");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
