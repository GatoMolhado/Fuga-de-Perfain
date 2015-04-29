using UnityEngine;
using System.Collections;

public class ObjectBehaviour : MonoBehaviour {

	private Rigidbody sceneObject;
	public Vector3 gravityForThisObject = new Vector3( 0f, -30, 0f);


	// Use this for initialization
	void Start () {
	
		sceneObject = GetComponent<Rigidbody> ();



	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		sceneObject.AddForce ((gravityForThisObject) * sceneObject.mass);

	}
}
