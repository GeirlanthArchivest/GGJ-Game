using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private float speed = 20;
	private float turnSpeed = 50;
	private float horizontalInput;
	private float forwardInput;
	public int maxHealth = 100;
	public int currentHealth;
	public GameObject Camera1;

	//public Healthbar Healthbar;

	// Start is called before the first frame update
	void Start()
	{
		currentHealth = maxHealth;
		//Healthbar.SetMaxHealth(maxHealth);

	}


    // Update is called once per frame
    void Update()
	{
		if (Camera1.activeSelf)
		{
			//get player input
			horizontalInput = Input.GetAxis("Horizontal");
			forwardInput = Input.GetAxis("Vertical");

			//Move the vehicle forward
			transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
			Vector3 forwardDirection = transform.rotation * Vector3.forward;
			Vector3 newVelocity = forwardDirection * speed * forwardInput;
			newVelocity.y = GetComponent<Rigidbody>().velocity.y;
			GetComponent<Rigidbody>().velocity = newVelocity;
		}
        else
        {
			GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
		
		//transform.Translate(Vector3.forward * speed * forwardInput);

		/*if (Input.GetKeyDown(KeyCode.Space))
		{
			TakeDamage(20);
		}*/

	}

	/*void TakeDamage(int damage)
	{
		currentHealth -= damage;
		Healthbar.SetHealth(currentHealth);
	}*/


}