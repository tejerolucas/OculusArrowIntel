using UnityEngine;
using System.Collections;

public class ManagerApps : MonoBehaviour {

	// Use this for initialization
	public void change (string escena) {
		Application.LoadLevel (escena);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.O)) {
			change("oculus");
		}
		if (Input.GetKeyDown (KeyCode.Y)) {
			change("youtube");
		}
		if (Input.GetKeyDown (KeyCode.M)) {
			change("manager");
		}
	}
}
