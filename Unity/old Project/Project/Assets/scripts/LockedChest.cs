using UnityEngine;
using System.Collections;

public class LockedChest : MonoBehaviour {

	public bool enter;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (enter == true) {
			if (Input.GetMouseButtonDown (0)) {
				GetComponent<AudioSource>().Play();
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
