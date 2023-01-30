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
    public float height = 2;
    //private Vector3 offset = new Vector3(0, 2, -7);


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position - player.transform.forward * distanceFromPlayer;
        transform.LookAt(player.transform.position);
        transform.position = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
    }
}