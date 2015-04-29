using UnityEngine;
using System.Collections;

public class ChestOpenBehavior : MonoBehaviour {

	bool open = false;
	bool enter;
	public GameObject BauFechado;
	
	void Start () {
		
	}
	
	void Update () {
		
		if(open == true){ 
			gameObject.SetActive(false);
			BauFechado.SetActive(true);
			open = false;
		}
		
		if(enter == true){
			if(Input.GetMouseButtonDown(0)){
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