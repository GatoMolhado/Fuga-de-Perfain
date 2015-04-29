using UnityEngine;
using System.Collections;

public class BolsaBehavior : MonoBehaviour {

	bool enter;
	public GameObject Tocha1;
	public GameObject Tocha2;
	public GameObject Tocha3;
	public GameObject Tocha4;
	public GameObject Tocha5;
	public GameObject Lareira;
	public GameObject Portanova;
	public GameObject InvisibleFriend;
	public GameObject InvisibleEnemyFeet;
	public GameObject InvisibleEnemyChain;
	bool showText;
	bool GUITrue = false;
	private float y;
	private float x;
	private Vector2 resolution;
	public GUIStyle Normalasstext;

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

		if(enter == true){
			if(Input.GetMouseButtonDown(0)){
				Tocha1.GetComponent<TochaBehavior>().enabled = true;
				Tocha2.GetComponent<TochaBehavior>().enabled = true;
				Tocha3.GetComponent<TochaBehavior>().enabled = true;
				Tocha4.GetComponent<TochaBehavior>().enabled = true;
				Tocha5.GetComponent<TochaBehavior>().enabled = true;
				Lareira.GetComponent<TochaBehavior>().enabled = true;
				Portanova.GetComponent<DoorBehavior>().enabled = true;
				Portanova.GetComponent<DoorLockedBehavior>().enabled = false;
				InvisibleFriend.GetComponent<InimigoBehavior>().enabled = true;
				InvisibleEnemyFeet.SetActive(true);
				InvisibleEnemyChain.SetActive(true);
				gameObject.SetActive(false);
			}
		}
	}

	void OnTriggerEnter (Collider other){
		
		if (other.gameObject.tag == "Player") {
			enter = true;
			GUITrue = true;
		}
	}
	
	void OnTriggerExit (Collider other){
		
		if (other.gameObject.tag == "Player") {
			enter = false;
			GUITrue = false;
		}
	}
	
	void OnGUI()
	{
		if (GUITrue == true) {
			GUI.Label (new Rect (400*x,600*y,250*x,120*y), "Eu posso usar este composto para acender \nas tochas e achar elas no escuro.", Normalasstext);
		}
	}
}
