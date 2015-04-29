using UnityEngine;
using System.Collections;

public class Creator1 : MonoBehaviour {

	public GameObject Sala3;
	public GameObject SalaFinal;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			Sala3.SetActive(true);
			SalaFinal.SetActive(true);
		}
	}
}
