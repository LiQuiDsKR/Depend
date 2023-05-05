using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		Rotate ();
	}

	void Move() {
		Vector2 moveVec2 = GameObject.Find ("JoystickL").GetComponent<Joystick> ().inputVector;
		Vector3 moveVec3 = new Vector3 (moveVec2.x, moveVec2.y, 0) * moveSpeed * 0.02f;
		transform.Translate (moveVec3);
	}

	void Rotate() {
		Vector2 moveVec2 = GameObject.Find ("JoystickR").GetComponent<Joystick> ().inputVector;
		Vector3 moveVec3 = new Vector3 (0, 0, Mathf.Atan2 (moveVec2.y, moveVec2.x));
		transform.rotation = Quaternion.Euler (moveVec3);
	}
}
