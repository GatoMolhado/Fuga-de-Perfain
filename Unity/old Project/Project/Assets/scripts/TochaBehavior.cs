using UnityEngine;
using System.Collections;

public class TochaBehavior : MonoBehaviour {

	bool lightup = true;
	bool enter;
	public GameObject Luz;
	public GameObject Fogo;
	public GameObject Luzguia;

	void Start () {
	}

	void Update () {
		if (lightup == true) {
			Fogo.SetActive(true);
			Luz.SetActive(true);
			Luzguia.SetActive(false);
		} else {
			Luz.SetActive(false);
			Fogo.SetActive(false);
			Luzguia.SetActive(true);
		}

		if(enter == true){
			if(Input.GetMouseButtonDown(0)){
				lightup = !lightup;
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
