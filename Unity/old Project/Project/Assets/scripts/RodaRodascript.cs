using UnityEngine;
using System.Collections;

public class RodaRodascript : MonoBehaviour {

	bool close;
	bool enter;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(enter == true){
			if(Input.GetMouseButtonDown(0)){
				transform.rotation *= Quaternion.Euler(0, 0, 40);
			}
		}
		if (transform.eulerAngles.z < 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
	}
	
	void OnTriggerEnter (Collider other){
		
		if (other.gameObject.tag == "Player") {
			enter = true;
		}
	}
	
	void OnTriggerExit (Collider other){
		
		if (other.gameObject.tag == "Player") {
			enter = false;
		}
	}
}
