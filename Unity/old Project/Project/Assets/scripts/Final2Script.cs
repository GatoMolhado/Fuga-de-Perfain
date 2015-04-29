using UnityEngine;
using System.Collections;

public class Final2Script : MonoBehaviour {
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Application.LoadLevel("MenuPrincipal");
		}
	}
}
