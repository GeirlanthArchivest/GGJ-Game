using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject WinUI;
    public static int count;

    #region Singleton
    public static PlayerManager instance;

    void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject Player;
    public GameObject Player2;

    void Update()
    {
        if (count == 8)
        {
            WinUIEnable();
        }
    }

    void WinUIEnable()
    {
        WinUI.SetActive(true);
        Time.timeScale = 0f;
    }
}