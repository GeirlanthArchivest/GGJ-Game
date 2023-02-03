using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneDialogue : MonoBehaviour
{
    public GameObject Dialogue1;
    public GameObject Dialogue2;
    public GameObject Dialogue3;
    public GameObject Dialogue4;
    public GameObject Dialogue5;

    public void dialogueBox2()
    {
        Dialogue2.SetActive(true);
        Dialogue1.SetActive(false);
    }
    public void dialogueBox3()
    {
        Dialogue3.SetActive(true);
        Dialogue2.SetActive(false);
    }
    public void dialogueBox4()
    {
        Dialogue4.SetActive(true);
        Dialogue3.SetActive(false);
    }
    public void dialogueBox5()
    {
        Dialogue5.SetActive(true);
        Dialogue4.SetActive(false);
    }
    public void dialogueBox6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Dialogue5.SetActive(false);
    }
}
