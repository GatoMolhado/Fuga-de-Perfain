using UnityEngine;
using System.Collections;

public class Creator2 : MonoBehaviour {

	public GameObject Sala1;
	public GameObject Sala2;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			Sala1.SetActive(true);
			Sala2.SetActive(true);
		}
	}
}
