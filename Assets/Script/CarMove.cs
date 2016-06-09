using UnityEngine;
using System.Collections;

public class CarMove : MonoBehaviour {
	public bool updateOn = false;
	// Use this for initialization
	void Start () {
	
	}
	void moveCar () {
		transform.Translate (0, 0, -0.1f);

	}
	void CarMoveOn() {
		updateOn = true;
	}
	// Update is called once per frame
	void Update () {
		if (updateOn == true) {
			moveCar ();
		}
	}
}
