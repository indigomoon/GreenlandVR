using UnityEngine;
using System.Collections;

public class RandomBob : MonoBehaviour 
{
	public Rigidbody rb;

	public float VProbability = 30;
	public float VThrust = 4000;

	//public float HProbability = 10;
	//public float HThrust = 3000;


	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	// void Update()
	void FixedUpdate() {
		// Randomly apply a force to the iceberg to make it bob up and down with random waves,
		// and prevent the spring motion from just damping to a stop.

		float chance;

		// Calculate Bob

		// Probability is the percent chance per second that an impulse will occur
		chance = Random.value;
		if (chance < (VProbability / 100 * Time.deltaTime)) {
			rb.AddForce (0, VThrust, 0, ForceMode.Force);
		}

		/*

		// Calculate Drift

		// Probability is the percent chance per second that an impulse will occur
		chance = Random.value;
		if (chance < (HProbability / 100 * Time.deltaTime)) {
			rb.AddForce (HThrust, 0, 0, ForceMode.Force);
		}
		chance = Random.value;
		if (chance < (HProbability / 100 * Time.deltaTime)) {
			rb.AddForce (0, 0, HThrust, ForceMode.Force);
		}
		*/

	}


}