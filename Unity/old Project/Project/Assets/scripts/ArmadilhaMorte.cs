using UnityEngine;
using System.Collections;

public class ArmadilhaMorte : MonoBehaviour {

	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerExit (Collider other){
		
		if (other.gameObject.tag == "Player") {
			Application.LoadLevel("Morte");
		}
	}
}
