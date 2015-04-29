using UnityEngine;
using System.Collections;

public class ChestBehavior : MonoBehaviour {

	bool open;
	bool enter;
	public GameObject BauAberto;
	public GameObject Sacola1;
	public GameObject Sacola2;
	public GameObject Sacola3;
	public GameObject Whispers1;
	private float y;
	private float x;
	private Vector2 resolution;
	public GUIStyle Normalasstext;
	bool GUITrue = false;

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
		
		if(open == true){ 
			gameObject.SetActive(false);
			BauAberto.SetActive(true);
			Sacola3.SetActive(true);
			Whispers1.SetActive(false);
			open = false;
		}
		
		if(enter == true){
			if(Input.GetMouseButtonDown(0)){
				open = !open;
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
			GUI.Label (new Rect (400*x,600*y,250*x,120*y), "Clique com o mouse para abrir o bau.", Normalasstext);
		}
	}
}