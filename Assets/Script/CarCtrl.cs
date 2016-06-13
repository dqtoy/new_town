using CnControls;
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
	public bool Direct_boll = true; 
	 
	// Use this for initialization
	void keyBoardInput () {
		float xx = CnInputManager.GetAxisRaw("Vertical");
		float zz = CnInputManager.GetAxisRaw("Horizontal");
			Direct_boll = false;
			lookDirection = -1 * xx * Vector3.forward + -1 * zz * Vector3.right;
			Speed = WalkSpeed; 
			CS = CarState.Walk;

		if (xx == 0 && zz == 0 && CS != CarState.Idle) {			
			CS = CarState.Idle;
			Direct_boll = true;
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
		if(Direct_boll == false)
			LookUpdate ();
	}
}
