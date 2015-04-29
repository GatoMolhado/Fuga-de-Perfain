using UnityEngine;
using System.Collections;

public class MenuMorte : MonoBehaviour {

	public GameObject Light1;
	public GameObject Light2;

	void Start () {
	}
	
	void Update () {

		if(Input.GetKey(KeyCode.DownArrow)){
			Light2.SetActive(true);
			Light1.SetActive(false);
		}
		if(Input.GetKey(KeyCode.UpArrow)){
			Light1.SetActive(true);
			Light2.SetActive(false);
		}
		if (Light1.active == true) {
			if(Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter)){
				Application.LoadLevel("Jogo");
			}
		}
		if (Light2.active == true) {
			if(Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter)){
				Application.LoadLevel("MenuPrincipal");
			}
		}
	}
}
