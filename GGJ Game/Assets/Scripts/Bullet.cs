using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bullet : MonoBehaviour
{
    public float life = 3;
    public PlayerManager PlayerManager;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            PlayerManager.count += 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            
        }
        else if (collision.collider.tag != "Enemy" && collision.collider.tag != "Player")
        {
            Destroy(gameObject);
        }
    }


}