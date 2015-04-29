using UnityEngine;
using System.Collections;

public class HelpTextDestroyer : MonoBehaviour {
	
	public GameObject BauAberto;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit (Collider other){
		
		if (other.gameObject.tag == "BauAberto") {
			BauAberto.GetComponent<HelpText>().enabled = false;
		}
	}
}
