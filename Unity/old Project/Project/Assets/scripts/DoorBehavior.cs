using UnityEngine;
using System.Collections;

public class DoorBehavior : MonoBehaviour {
	
	public bool open;
	public bool enter;
	
	void Start () {
	}
	
	void Update () {

		if (open == true) { 
			var target = Quaternion.Euler (0, 180, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, target, Time.deltaTime * 2);
		}

		if (open == false) {
			var target1 = Quaternion.Euler (0, 90, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, target1, Time.deltaTime * 2);
		}

		if (enter == true) {
			if (Input.GetMouseButtonDown (0)) {
				GetComponent<AudioSource>().Play();
				open = !open;
			}
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
