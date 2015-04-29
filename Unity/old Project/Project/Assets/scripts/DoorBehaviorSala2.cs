
using UnityEngine;
using System.Collections;

public class DoorBehaviorSala2 : MonoBehaviour {

	public bool open;
	public bool enter;
	public bool puzzle1;
	public bool puzzle2;
	public GUIStyle Normalasstext;
	bool LockedText = false;
	bool HalfPuzzleText = false;
	bool HalfPuzzleCompleted = false;
	private float y;
	private float x;
	private Vector2 resolution;
	public GameObject Whispers2;
	public GameObject PedraPorta1;
	public GameObject PedraPorta2;
	public GameObject PedraPorta12;
	public GameObject PedraPorta22;
	public float TextTimer = 0.0f;
	public GameObject A;
	public GameObject B;

	void Start () {
		resolution = new Vector2(Screen.width, Screen.height);
		
		x=Screen.width/1440.0f; // 1920 is the x value of the working resolution (as described in the first point)
		
		y=Screen.height/729.0f; // 1042 is the y value of the working resolution (as described in the first point)
	}
	
	void Update () {

		if(Screen.width!=resolution.x || Screen.height!=resolution.y)
		{
			resolution=new Vector2(Screen.width, Screen.height);
			x=resolution.x/1440.0f;
			y=resolution.y/729.0f;
		}
		if (((puzzle1 == true && puzzle2 == false) || (puzzle1 == false && puzzle2 == true)) && enter == true) {
			HalfPuzzleText = true;
		}
		if (HalfPuzzleText == true) {
			TextTimer += Time.deltaTime;
		}
		if (TextTimer >= 5) {
			HalfPuzzleText = false;
			TextTimer = 0.0f;
		}

		if (puzzle1 == true && puzzle2 == true) {

			if (open == true) { 
				var target = Quaternion.Euler (90, 90, 0);
				transform.localRotation = Quaternion.Slerp (transform.localRotation, target, Time.deltaTime * 10);
				PedraPorta1.SetActive(false);
				PedraPorta2.SetActive(false);
				PedraPorta12.SetActive(true);
				PedraPorta22.SetActive(true);
			}
		
			if (open == false) {
				var target1 = Quaternion.Euler (90, 0, 0);
				transform.localRotation = Quaternion.Slerp (transform.localRotation, target1, Time.deltaTime * 10);
				PedraPorta1.SetActive(true);
				PedraPorta2.SetActive(true);
				PedraPorta12.SetActive(false);
				PedraPorta22.SetActive(false);
			}
		
			if (enter == true) {
				if (Input.GetMouseButtonDown (0)) {
					Whispers2.SetActive(false);
					GetComponent<AudioSource> ().Play ();
					open = !open;
				}
			}
		}
		if (enter == true && puzzle1 == false && puzzle2 == false) {
			if (Input.GetMouseButtonDown (0)) {
				LockedText = true;
			}
		}
		if ((enter == true) && (A.active == true || B.active == true)) {
			if (A.active == true && Input.GetMouseButtonDown (0)) {
				puzzle1 = true;
				PedraPorta1.SetActive(true);
			}
			if (B.active == true && Input.GetMouseButtonDown (0)) {
				puzzle2 = true;
				PedraPorta2.SetActive(true);
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
			LockedText = false;
		}
	}

	void OnGUI() {
		if (LockedText == true) {
			GUI.Label (new Rect (400*x,600*y,250*x,120*y), "'Essa porta parece funcionar com um mecanismo...'", Normalasstext);
		}
		if (HalfPuzzleText == true) {
			GUI.Label (new Rect (400*x,600*y,250*x,120*y), "'Agora falta a outra pedra.'", Normalasstext);
		}
	}
}
