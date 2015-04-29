using UnityEngine;
using System.Collections;

public class MouseHide : MonoBehaviour {

	public Texture2D crosshairTexture;
	public float crosshairScale = 1;

	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.lockState = CursorLockMode.None;
	}

	void OnGUI()
	{
		//if not paused
		if(Time.timeScale != 0)
		{
			if(crosshairTexture!=null)
				GUI.DrawTexture(new Rect((Screen.width-crosshairTexture.width*crosshairScale)/2 ,(Screen.height-crosshairTexture.height*crosshairScale)/2, crosshairTexture.width*crosshairScale, crosshairTexture.height*crosshairScale),crosshairTexture);
			else
				Debug.Log("No crosshair texture set in the Inspector");
		}
	}
}
