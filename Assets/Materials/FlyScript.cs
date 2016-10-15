using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour {

	public static int speed = 0;
	public static int topspeed = 357;
	//public float elevation = 0;
	public Transform cameraObject;
	Transform initialposition;
	// Use this for initialization
	void Start () {
		initialposition=transform;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)){
			speed=0;
			transform.position += cameraObject.forward * speed * Time.deltaTime;
		} else if (Input.GetAxis("Mouse X")>.2)
       		{
			transform.position = initialposition.position;
		} else if (speed<topspeed){
		    	transform.position += cameraObject.forward * speed * Time.deltaTime;
			speed+=10;
                } else {
			transform.position += cameraObject.forward * speed * Time.deltaTime;
		}
		
		//var pos = transform.position;
		//pos.y = elevation;
		//transform.position = pos;

	}
}
