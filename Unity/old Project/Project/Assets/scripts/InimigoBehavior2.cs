using UnityEngine;
using System.Collections;

public class InimigoBehavior2 : MonoBehaviour {
	
	public float EnemyTimer = 0.0f;
	public float TextTimer = 0.0f;
	bool showText = true;
	bool IncreaseTime;
	bool GoneEnemy;
	bool GUIenable;
	bool EnemyAppear = true;
	bool TextTimerCount = true;
	public GUIStyle Normalasstext;
	public GameObject Luz1;
	public GameObject Luz2;
	public GameObject Luz3;
	public GameObject Luz4;
	public GameObject InvisibleEnemyFeet;
	public GameObject InvisibleEnemyChain;
	public GameObject InvisibleEnemyDoor;
	public GameObject InvisibleEnemyDoorOpening;
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
		
		if(Screen.width!=resolution.x || Screen.height!=resolution.y)
		{
			resolution=new Vector2(Screen.width, Screen.height);
			x=resolution.x/1440.0f;
			y=resolution.y/729.0f;
		}
		
		if ((Luz1.active == false) && (Luz2.active == false) && (Luz3.active == false) && (Luz4.active == false)) {
			EnemyTimer = 0f;
			GoneEnemy = true;
			showText = true;
			TextTimerCount = true;
			if (TextTimer >= 5) {
				InvisibleEnemyDoor.SetActive(false);
				InvisibleEnemyFeet.SetActive(false);
				InvisibleEnemyChain.SetActive(false);
				GetComponent<InimigoBehavior2>().enabled = false;
			}
		} else {
			EnemyTimer += Time.deltaTime;
		}
		
		if (EnemyTimer >= 20) {
			InvisibleEnemyFeet.SetActive(false);
			InvisibleEnemyChain.SetActive(false);
			InvisibleEnemyDoor.SetActive(true);
		}
		
		if (EnemyTimer >= 29) {
			InvisibleEnemyDoor.SetActive(false);
			InvisibleEnemyDoorOpening.SetActive(true);
		}
		
		if (EnemyTimer >= 30) {
			Debug.Log("GAME OVER");
			Application.LoadLevel("TransitionDeath");
		}
		
		if (TextTimer >= 5) {
			GoneEnemy = false;
			EnemyAppear = false;
			showText = false;
			TextTimerCount = false;
			TextTimer = 0f;
		}
		
		if (TextTimerCount == true) {
			TextTimer += Time.deltaTime;
		}
	}
	
	void OnGUI()
	{
		if (showText == true) {
			if (GoneEnemy == true) {
				GUI.Label (new Rect (400*x,600*y,250*x,120*y), "'O inimigo desistiu de me procurar.'", Normalasstext);
			}
			if (EnemyAppear == true) {
				GUI.Label (new Rect (400*x,600*y,250*x,120*y), "'O guarda voltou!'", Normalasstext);
			}
		}
	}
}
