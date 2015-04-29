using UnityEngine;
using System.Collections;

public class Morte : MonoBehaviour {

	public float MotherDeath = 0.0f;
	public GameObject Bodyfalling;

	void Start () {
		GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame
	void Update () {
		MotherDeath += Time.deltaTime;
		if (MotherDeath >= 0.5) {
			Bodyfalling.SetActive (true);
		}
		if (MotherDeath >= 3) {
			Application.LoadLevel("Morte");
		}
	}
}
