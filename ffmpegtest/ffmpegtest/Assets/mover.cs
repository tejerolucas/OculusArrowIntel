using UnityEngine;
using System.Collections;

public class mover : MonoBehaviour {
	public GameObject target;
	// Use this for initialization
	void moverm () {
		iTween.MoveTo(this.gameObject,iTween.Hash("path",iTweenPath.GetPath("camino"),"time",30));
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt(target.transform.position);
		if(Input.GetKeyDown(KeyCode.R)){
			moverm();
		}
	}


}
