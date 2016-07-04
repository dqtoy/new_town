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
		check1 = false;
		check = true;
		//transform.Rotate(0,180.0f,0);
		transform.rotation = Quaternion.Euler (0, 270.0f, 0);
	}

	void RightGo ()
	{
		check = false;
		check1 = true;
		transform.rotation = Quaternion.Euler (0, 90.0f, 0);
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

		if (check) {

			transform.Translate (new Vector3(Mathf.Clamp(-(Time.deltaTime*2.0f), 0.0F, 0), 0, 0));

		}
	
		if (check1) {
			PS = PlayerState1.Walk;
			anim.SetTrigger("walking");
			transform.Translate (new Vector3(Mathf.Clamp(Time.deltaTime*2.0f, 0.0F, 0), 0, 0));
		}

		//AnimationUpdate ();
	}
}
