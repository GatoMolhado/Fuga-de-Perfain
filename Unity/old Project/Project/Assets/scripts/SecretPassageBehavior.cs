using UnityEngine;
using System.Collections;

public class SecretPassageBehavior : MonoBehaviour {

	public GameObject RodaRoda1;
	public GameObject RodaRoda2;
	public GameObject RodaRoda3;
	public GameObject RodaRoda4;
	public bool Lock1 = false;
	public bool Lock2 = false;
	public bool Lock3 = false;
	public bool Lock4 = false;
	public GameObject Whispers3;
	int puzzle = 0;

	void Start () {
	
	}

	void Update () {
		if (RodaRoda1.transform.eulerAngles.z == 160){
			Lock1 = true;
		} else {
			Lock1 = false;
		}
		if (RodaRoda2.transform.eulerAngles.z == 160) {
			Lock2 = true;
		} else {
			Lock2 = false;
		}
		if (RodaRoda3.transform.localEulerAngles.z == 80){
			Lock3 = true;
		} else {
			Lock3 = false;
		}
		if (RodaRoda4.transform.localEulerAngles.z == 240){
			Lock4 = true;
		} else {
			Lock4 = false;
		}

		if (Lock1 == true & Lock2 == true & Lock3 == true & Lock4 == true) {
			var target = Quaternion.Euler (270, 90, 0);
			transform.localRotation = Quaternion.Slerp (transform.localRotation, target, Time.deltaTime * 2);
			Whispers3.SetActive(false);
		}
	}
}
