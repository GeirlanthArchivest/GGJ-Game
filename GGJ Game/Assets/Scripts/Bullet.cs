using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bullet : MonoBehaviour
{
    public float life = 3;
    public int count = 0;
    public GameObject WinUI;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            count += 1;
            if (count == 8)
            {
                WinUIEnable();
            }
        }
        else if (collision.collider.tag != "Enemy" && collision.collider.tag != "Player")
        {
            Destroy(gameObject);
        }
    }

    void WinUIEnable()
    {
        WinUI.SetActive(true);
        Time.timeScale = 0f;
    }
}