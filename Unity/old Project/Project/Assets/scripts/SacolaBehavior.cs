using UnityEngine;
using System.Collections;

public class SacolaBehavior : MonoBehaviour {

	int puzzle = 0;
	public GameObject Sacola1;
	public GameObject Sacola2;
	public GameObject Sacola3;
	public GameObject copo;
	private float y;
	private float x;
	private Vector2 resolution;
	public GUIStyle Normalasstext;
	public float TextTimer = 0.0f;
	bool ajuda = false;

	void Start () {
		resolution = new Vector2(Screen.width, Screen.height);
		
		x=Screen.width/1440.0f; // 1920 is the x value of the working resolution (as described in the first point)
		
		y=Screen.height/729.0f; // 1042 is the y value of the working resolution (as described in the first point)
	}
	
	// Update is called once per frame
	void Update () {
		if (Screen.width != resolution.x || Screen.height != resolution.y) {
			resolution = new Vector2 (Screen.width, Screen.height);
			x = resolution.x / 1440.0f;
			y = resolution.y / 729.0f;
		}
		if (puzzle == 3) {
			copo.SetActive(true);
			puzzle = 4;
		}
		if (puzzle == 2) {
			ajuda = true;
		}
		if (ajuda == true) {
			TextTimer += Time.deltaTime;
		}
		if (TextTimer >= 4) {
			ajuda = false;
		}
	}

	void OnTriggerEnter (Collider other){
		
		if (other.gameObject.tag == "Sacola1") {
			Sacola1.SetActive(false);
			GetComponent<AudioSource>().Play();
			puzzle ++;
		}

		if (other.gameObject.tag == "Sacola2") {
			Sacola2.SetActive(false);
			GetComponent<AudioSource>().Play();
			puzzle ++;
		}

		if (other.gameObject.tag == "Sacola3") {
			Sacola3.SetActive(false);
			GetComponent<AudioSource>().Play();
			puzzle ++;
		}
	}
	
	void OnGUI()
	{
		if (ajuda == true) {
			GUI.Label (new Rect (400*x,600*y,250*x,120*y), "'Esse tempo preso me enfraqueceu. Preciso permanecer\n no escuro caso alguem se aproxime'", Normalasstext);
		}
	}
}
