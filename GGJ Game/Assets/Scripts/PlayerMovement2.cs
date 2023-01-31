using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement2 : MonoBehaviour
{
	private float speed = 40;
	private float turnSpeed = 100;
	private float horizontalInput;
	private float forwardInput;
	public float lookRadius;
	public int maxHealth = 100;
	public int currentHealth;
	public GameObject Camera2;
	public GameObject dungeon1;
	public GameObject dungeon2;
	public GameObject Player1;
	public GameObject Gun;

	Transform target;
	NavMeshAgent agent;

	//public Healthbar Healthbar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		//Healthbar.SetMaxHealth(maxHealth);
		target = PlayerManager.instance.Player.transform;
		agent = GetComponent<NavMeshAgent>();

	}


    // Update is called once per frame
    void Update()
	{ 
		if (Camera2.activeSelf)
        {
			//get player input
			horizontalInput = Input.GetAxis("Horizontal");
			forwardInput = Input.GetAxis("Vertical");

			//Move the vehicle forward
			transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
			Vector3 forwardDirection = transform.rotation * Vector3.forward;
			Vector3 newDirection = forwardDirection * forwardInput * speed;
			agent.SetDestination(transform.position + newDirection);

			dungeon1.SetActive(false);
			dungeon2.SetActive(true);
			Player1.SetActive(false);
			Gun.SetActive(true);

		}
        else
        {
			dungeon1.SetActive(true);
			dungeon2.SetActive(false);
			Player1.SetActive(true);
			Gun.SetActive(false);
			float distance = Vector3.Distance(target.position, transform.position);
			if (distance <= lookRadius)
			{
				agent.SetDestination(target.position);
				
			}
		}

		

		//Move the vehicle forward
		
		//transform.Translate(Vector3.forward * speed * forwardInput);

		/*if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}*/

	}

	void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, lookRadius);
	}


	/*void TakeDamage(int damage)
	{
		currentHealth -= damage;
		Healthbar.SetHealth(currentHealth);
	}*/


}