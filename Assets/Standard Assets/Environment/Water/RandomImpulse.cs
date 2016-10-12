using UnityEngine;
using System.Collections;

public class RandomImpulse : MonoBehaviour 
{
	public Rigidbody rb;
	public float Probability = 30;
	public float Thrust = 4000;


	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() {
		// Randomly apply a force to the iceberg to make it bob up and down with random waves,
		// and prevent the spring motion from just damping to a stop.

		// Probability is the percent chance per second that an impulse will occur
		float chance = Random.value;
		if (chance < (Probability / 100 * Time.deltaTime)) {
			rb.AddForce (0, Thrust, 0, ForceMode.Force);
		}
	}

	// Update is called once per frame
	void Update () {

	}

}