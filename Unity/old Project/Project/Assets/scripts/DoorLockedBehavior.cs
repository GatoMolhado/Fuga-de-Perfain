using UnityEngine;
using System.Collections;

public class DoorLockedBehavior : MonoBehaviour {
	
	public bool enter;
	public GUIStyle Normalasstext;
	bool GUIenabled = false;
	private float y;
	private float x;
	private Vector2 resolution;

	void Start () {

		resolution = new Vector2(Screen.width, Screen.height);
		
		x=Screen.width/1440.0f; // 1920 is the x value of the working resolution (as described in the first point)
		
		y=Screen.height/729.0f; // 1042 is the y value of the working resolution (as described in the first point)
	
	}
	
	// Update is called once per frame
	void Update () {

		if (enter == true) {
			if (Input.GetMouseButtonDown (0)) {
				GUIenabled = true;
			}
		}
		if(Screen.width!=resolution.x || Screen.height!=resolution.y)
		{
			resolution=new Vector2(Screen.width, Screen.height);
			x=resolution.x/1440.0f;
			y=resolution.y/729.0f;
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
			GUIenabled = false;
		}
	}

	void OnGUI()
	{
		if (GUIenabled == true) {
			GUI.Label (new Rect (400*x,600*y,250*x,120*y), "A porta esta trancada...", Normalasstext);
		}
	}
}
