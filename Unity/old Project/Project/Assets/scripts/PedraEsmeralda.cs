using UnityEngine;
using System.Collections;

public class PedraEsmeralda: MonoBehaviour {
	
	bool enter = false;
	public GameObject A;
	public GameObject SecondEnemy;
	public GameObject InvisibleEnemyFeet;
	public GameObject InvisibleEnemyChain;

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (enter == true) {
			if (Input.GetMouseButtonDown (0)) {
				A.SetActive (true);
				SecondEnemy.GetComponent<InimigoBehavior2>().enabled = true;
				InvisibleEnemyFeet.SetActive(true);
				InvisibleEnemyChain.SetActive(true);
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