using UnityEngine;
using System.Collections;

public enum PlayerState1
{
	
	Idle,
	Walk,
	Run,
	Attack,
	Dead,
	
}

public class QuestionPlayerCtrl : MonoBehaviour {

	public PlayerState1 PS;
	public Vector3 lookDirection;
	public float Speed = 0f;
	public float WalkSpeed = 6f;
	public float RunSpeed = 12f;
	public Animator anim;
	public UIButton LeftButton;
	public UIButton RightButton;
	private bool check = false;
	private bool check1 = false;

	void Awake()
	{
		LeftButton.onClick.Add (new EventDelegate (LeftGo));
		RightButton.onClick.Add (new EventDelegate (RightGo));
	}

	void KeyboardInput ()
	{

		
		if (PS != PlayerState1.Attack) {

			Speed = WalkSpeed;
			PS = PlayerState1.Walk;
			anim.SetFloat ("Speed_f",0.5f);
			
			/*if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow) ||
			    Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.DownArrow)) {
				
				lookDirection = xx * Vector3.forward + zz * Vector3.right;
				Speed = WalkSpeed;
				PS = PlayerState.Walk;
				anim.SetFloat ("Speed_f",0.5f);
			}*/
			
			/*if (xx == 0 && zz == 0 && PS != PlayerState.Idle) {			
				PS = PlayerState.Idle;
				anim.SetFloat ("Speed_f",0.0f);
				Speed = 0f;
			}*/
			
		}
		
	}

	void LeftGo()
	{
		//lookDirection = 1.0f * Vector3.forward + 1.0f * Vector3.right;
		//Speed = WalkSpeed;
		//PS = PlayerState1.Walk;
		//anim.SetFloat ("Speed_f",0.5f);
		//transform.Translate (Vector3.forward * -0.5f * Time.deltaTime);
		check = true;
	}

	void RightGo ()
	{
		check1 = true;
	}
	
	void Start()
	{
		anim = this.GetComponent<Animator> ();
	}
	
	

	
	void Update ()
	{
		if(PS != PlayerState1.Dead){
			//KeyboardInput ();
			//transform.Translate (Vector3.forward * -0.5f * Time.deltaTime);
		}

		if(check) transform.Translate (Vector3.left * Time.deltaTime, Camera.main.transform);
	
		if(check1) transform.Translate (Vector3.right * Time.deltaTime, Camera.main.transform);
		//AnimationUpdate ();
	}
}
