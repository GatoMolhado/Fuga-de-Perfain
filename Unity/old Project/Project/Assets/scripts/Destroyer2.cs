using UnityEngine;
using System.Collections;

public class Destroyer2 : MonoBehaviour {

	public GameObject Sala1;
	public GameObject Sala2;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			Sala1.SetActive(false);
			Sala2.SetActive(false);
		}
	}
}
