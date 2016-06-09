using UnityEngine;
using System.Collections;

public enum CarState
{
	
	Idle,
	Walk
}

public class CarCtrl : MonoBehaviour {
	public CarState CS;
	public float Speed = 0f; 
	public float WalkSpeed = 10f;
	public Vector3 lookDirection;
	 
	// Use this for initialization
	void keyBoardInput () {
		float xx = Input.GetAxisRaw ("Vertical");
		float zz = Input.GetAxisRaw ("Horizontal");

		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow) ||
		    Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow)) {

			lookDirection = -1 * xx * Vector3.forward + -1 * zz * Vector3.right;
			Speed = WalkSpeed;
			CS = CarState.Walk;
		}

		if (xx == 0 && zz == 0 && CS != CarState.Idle) {			
			CS = CarState.Idle;
			Speed = 0f;
		}
	}

	void LookUpdate ()
	{	
		Quaternion R = Quaternion.LookRotation (lookDirection);
		transform.rotation = Quaternion.RotateTowards (transform.rotation, R, 10f);
		transform.Translate (Vector3.forward * Speed * -1 * Time.deltaTime);	
	}
	
	// Update is called once per frame
	void Update () {
		keyBoardInput ();
		LookUpdate ();
	}
}
