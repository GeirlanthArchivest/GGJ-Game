using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtons : MonoBehaviour
{
    public GameObject Dialogue1;
    public GameObject Dialogue2;
    private bool GameIsPaused = false;


    // Update is called once per frame
    void Update()
    {
        if (PlayerManager.count == 6 && GameIsPaused == false)
        {
            Dialogue1.SetActive(true);
            GameIsPaused = true;
            Time.timeScale = 0f;
        }
        else if (Input.GetButtonDown("2Key"))
        {
            dialogueBox2();
        }
    }

    public void dialogueBox1()
    {
        Dialogue2.SetActive(true);
        Dialogue1.SetActive(false);
    }
    public void dialogueBox2()
    {
        Debug.Log("Test");
        Dialogue2.SetActive(false);
        Time.timeScale = 1f;
    }
}
