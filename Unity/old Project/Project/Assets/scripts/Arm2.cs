using UnityEngine;
using System.Collections;

public class Arm2 : MonoBehaviour {

	bool enter = false;
	
	void Start () {
		
	}
	
	void Update () {
		
		//Verifica se a armadilha esta aberta ou fechada, e coloca a posiçao de rotaçao referente ao estado
		if(enter == true){ 
			var target = Quaternion.Euler (340, 90, -89);
			transform.localRotation = Quaternion.Slerp(transform.localRotation, target, Time.deltaTime * 10);
		}
		
		if(enter == false){
			var target1 = Quaternion.Euler (270 , 0, 0);
			transform.localRotation = Quaternion.Slerp(transform.localRotation, target1, Time.deltaTime * 10);
		}
	}
	//Verifica se o jogador colidiu com a bounding box do objeto
	void OnTriggerEnter (Collider other){
		
		if (other.gameObject.tag == "Player") {
			enter = true;
		}
	}
}
