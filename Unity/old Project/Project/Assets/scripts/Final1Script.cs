using UnityEngine;
using System.Collections;

public class Final1Script : MonoBehaviour {

	public GameObject RawImage1;
	void Start () {
		
	}
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			RawImage1.SetActive(true);
		}
	}
}