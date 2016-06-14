using CnControls;
using UnityEngine;
using System.Collections;

public enum PlayerState
{
	
	Idle,
	Walk,
	Run,
	Attack,
	Dead,
	
}

public class Player_Ctrl : MonoBehaviour {

	public PlayerState PS;
	public Vector3 lookDirection;
	public float Speed = 0f;
	public float WalkSpeed = 6f;
	public float RunSpeed = 12f;
	public Animator anim;

	void KeyboardInput ()
	{
		float xx = CnInputManager.GetAxisRaw("Vertical");
		float zz = CnInputManager.GetAxisRaw("Horizontal");

		if (PS != PlayerState.Attack) {

			lookDirection = xx * Vector3.forward + zz * Vector3.right;
			Speed = WalkSpeed;
			PS = PlayerState.Walk;
			anim.SetFloat ("Speed_f",0.5f);

			/*if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow) ||
			    Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow)) {
				
				lookDirection = xx * Vector3.forward + zz * Vector3.right;
				Speed = WalkSpeed;
				PS = PlayerState.Walk;
				anim.SetFloat ("Speed_f",0.5f);
			}*/
			
			if (xx == 0 && zz == 0 && PS != PlayerState.Idle) {			
				PS = PlayerState.Idle;
				anim.SetFloat ("Speed_f",0.0f);
				Speed = 0f;
			}
			
		}
		
	}

	void Start()
	{
		anim = this.GetComponent<Animator> ();
	}


	void LookUpdate ()
	{	
		
		Quaternion R = Quaternion.LookRotation (lookDirection);
		transform.rotation = Quaternion.RotateTowards (transform.rotation, R, 10f);
		transform.Translate (Vector3.forward * Speed * Time.deltaTime);	

	}
	
	void Update ()
	{
		if(PS != PlayerState.Dead){
			KeyboardInput ();
			LookUpdate ();
		}
		
		//AnimationUpdate ();
	}
}
