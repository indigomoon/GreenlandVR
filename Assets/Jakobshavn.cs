using UnityEngine;
using System.Collections;

public class Jakobshavn : MonoBehaviour {
	
	public GameObject Jakobshavntext;
	public Collider othertwo;

	void Start(){
		Debug.LogWarning ("Start");
		Jakobshavntext.SetActive(false);
	}

	void OnTriggerEnter(Collider other) {
		Debug.LogWarning ("Enter triggered by "+other.name + " with " + this.name);
    	Jakobshavntext.SetActive(true);
		//Destroy(other.gameObject);
	}

	void OnTriggerExit(Collider other) {
		Debug.LogWarning ("Exit triggered by "+other.name + " with " + this.name);

    	Jakobshavntext.SetActive(false);
		//Destroy(other.gameObject);
	}

	void Update(){
		
	}
	
}
