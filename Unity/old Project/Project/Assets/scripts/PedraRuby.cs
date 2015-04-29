using UnityEngine;
using System.Collections;

public class PedraRuby : MonoBehaviour {

	bool enter = false;
	public GameObject B;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (enter == true) {
			if (Input.GetMouseButtonDown (0)) {
				B.SetActive (true);
				gameObject.SetActive (false);
			}
		}
	}
	
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			enter = true;
		}
	}
}
