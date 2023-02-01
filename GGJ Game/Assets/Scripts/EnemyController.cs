using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public float lookRadius = 10f;
    public Transform[] waypoints;
    int waypointsIndex;
    Vector3 target2;
    public GameObject cam2;
    public float rotationSpeed = 30f;
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 100;
    private float nextFire;
    public int timer;

    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerManager.instance.Player.transform;
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();

    }

    // Update is called once per frame
    void Update()
    {
        if (cam2.activeSelf)
        {
            target = PlayerManager.instance.Player2.transform;
        }
        else
        {
            target = PlayerManager.instance.Player.transform;
        }

        float distance2 = Vector3.Distance(target.position, transform.position);

        if (distance2 <= lookRadius)
        {
            agent.SetDestination(target.position);
            if (distance2 <= agent.stoppingDistance)
            {
                RotateTowards(target);
                if (Time.time > nextFire)
                {
                    nextFire += 0.4f;
                    ++timer;
                    ShootAt();
                }
            }
        }
        else
        {
            UpdateDestination();
            if (Vector3.Distance(transform.position, target2) < 4)
            {
                IterateWaypointIndex();
                UpdateDestination();
            }
        }

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    void UpdateDestination()
    {
        target2 = waypoints[waypointsIndex].position;
        agent.SetDestination(target2);
    }

    void IterateWaypointIndex()
    {
        waypointsIndex++;
        if (waypointsIndex == waypoints.Length)
        {
            waypointsIndex = 0;
        }
    }
    void ShootAt()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
    }

    private void RotateTowards(Transform target)
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
    }
}