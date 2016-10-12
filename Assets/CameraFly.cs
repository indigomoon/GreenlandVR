using UnityEngine;
using System.Collections;

public class CameraFly : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * 1f * Time.deltaTime;
	}
}
