using UnityEngine;
using System.Collections;

public class Whisper1 : MonoBehaviour {

	private float y;
	private float x;
	private Vector2 resolution;
	public GUIStyle Normalasstext;
	public float TextTimer = 0.0f;
	public float MotherDeath = 0.0f;
	bool DeathTime = false;
	public bool starthelp = true;
	bool ajuda1 = false;
	bool ajuda2 = false;
	bool enter = false;

	void Start () {

		resolution = new Vector2(Screen.width, Screen.height);
		
		x=Screen.width/1440.0f; // 1920 is the x value of the working resolution (as described in the first point)
		
		y=Screen.height/729.0f; // 1042 is the y value of the working resolution (as described in the first point)
	}
	
	// Update is called once per frame
	void Update () {
		if (TextTimer >= 5) {
			starthelp = false;
			TextTimer = 0.0f;
		}
		if (Screen.width != resolution.x || Screen.height != resolution.y) {
			resolution = new Vector2 (Screen.width, Screen.height);
			x = resolution.x / 1440.0f;
			y = resolution.y / 729.0f;
		}
		if (starthelp == true) {
			TextTimer += Time.deltaTime;
		}
		if (enter == true) {

			TextTimer += Time.deltaTime;

			if (TextTimer >= 30 & TextTimer <= 39) {
				ajuda1 = true;
				DeathTime = true;
			}

			if (TextTimer >= 60 & TextTimer <= 69) {
				ajuda2 = true;
				DeathTime = true;
			}

			if (DeathTime == true) {
				MotherDeath += Time.deltaTime;
			}

			if (MotherDeath >= 10) {
				ajuda1 = false;
				ajuda2 = false;
				DeathTime = false;
				MotherDeath = 0f;
			}
		}
	}

	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "Player") {
			enter = true;
		}
	}

	void OnGUI()
	{
		if (starthelp == true) {
			GUI.Label (new Rect (400*x,600*y,250*x,120*y), "'Preciso encontrar o caminho ate a biblioteca!'", Normalasstext);
		}
		if (ajuda1 == true) {
			GUI.Label (new Rect (400*x,600*y,250*x,120*y), "Aquele quadro me parece familiar...", Normalasstext);
		}
		if (ajuda2 == true) {
			GUI.Label (new Rect (400*x,600*y,250*x,120*y), "Preciso de algo que me ajude a apagar e acender as tochas.\nTalvez os baús tenham algo...", Normalasstext);
		}
	}
}
