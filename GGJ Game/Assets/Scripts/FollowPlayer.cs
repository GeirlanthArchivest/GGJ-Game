using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject player;
    public float distanceFromPlayer = 5;
    public float height = 5;
    //private Vector3 offset = new Vector3(-5, 5, 0);


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position - player.transform.forward * distanceFromPlayer;
        transform.LookAt(player.transform.position);
        transform.position = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
        //transform.position = player.transform.position + offset;
    }

}