using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
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
    public GameObject wall;

    void Update()
    {
        if (count == 12)
        {
            wallDisable();
        }
    }

    void wallDisable()
    {
        wall.SetActive(false);
    }
}