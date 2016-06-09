using UnityEngine;
using System.Collections;

public class CollisonCarMove : MonoBehaviour {

	public bool updateOn = false;
	public float Speed = -0.5f;

	void moveCar () {

		transform.Translate (0, 0, Speed);
		
	}
	void SpeedCtrl() {
		Speed = 0;
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
