using UnityEngine;
using System.Collections;

public class TrapSound : MonoBehaviour {

	bool Trigerred = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){
		if (Trigerred == false){
			if (other.gameObject.tag == "Player") {
				GetComponent<AudioSource>().Play();
				Trigerred = true;
			}
		}
	}
}
