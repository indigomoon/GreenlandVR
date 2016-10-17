using UnityEngine;
using System.Collections;

public class PlatformConfigure : MonoBehaviour {

	public GameObject googleViewer;

	// Use this for initialization
	void Start () {
		
		Debug.Log ("** Platform is " + Application.platform);

		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			// iPhone settings
			googleViewer.SetActive (true);

		} else if (Application.platform == RuntimePlatform.Android) {
			// Android settings
			googleViewer.SetActive (false);
		
		} else if (Application.platform == RuntimePlatform.OSXPlayer) {
			// Mac desktop settings
			googleViewer.SetActive (false);

		} else if (Application.platform == RuntimePlatform.WindowsPlayer) {
			// Windows desktop settings
			googleViewer.SetActive (false);

		} else {
			// For other platforms, such as OSXEditor and WindowsEditor, 
			// don't change the state so it can be changed for debugging
			// in Unity IDE.
		}

	}

}
