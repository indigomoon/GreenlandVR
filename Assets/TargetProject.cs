using UnityEngine;
using System.Collections;

public class TargetProject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Application.platform != RuntimePlatform.IPhonePlayer)
		{
            		gameObject.SetActive(false);
		}
	}
}
