using UnityEngine;
using System.Collections;

public class QuestionCameraCtrl : MonoBehaviour
{

	public GameObject player;

	public float Speed = 10f; 
	Vector3 Pos;
	// Use this for initialization
	void Update () {
		Pos = new Vector3 (player.transform.position.x+2.39f, 1.2f, -10.0f);
		
		this.gameObject.transform.position = Vector3.Lerp (this.gameObject.transform.position, Pos, Speed * Time.deltaTime);
	}
}
