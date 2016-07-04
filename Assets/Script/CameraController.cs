using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	public float Distance = 7f;
	public float Height = 5f;
	public float Speed = 10f;
	Vector3 Pos;
	// Use this for initialization
	void Update () {
		Pos = new Vector3 (player.transform.position.x - 5.0f, Height, player.transform.position.z - Distance);

		this.gameObject.transform.position = Vector3.Lerp (this.gameObject.transform.position, Pos, Speed * Time.deltaTime);
	}
}
