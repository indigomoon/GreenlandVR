using UnityEngine;
using System.Collections;

public class RandomDrift : MonoBehaviour 
{
	public Rigidbody rb;

	public float HProbability = 5;
	public float HThrust = 2000;


	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	// void Update()
	void FixedUpdate() {
		// Randomly apply a force to the anchor to make it drift

		float chance;


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
	}


}