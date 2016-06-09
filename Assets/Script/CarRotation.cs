using UnityEngine;
using System.Collections;

public class CarRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnTriggerEnter(Collider Get) {
		if (Get.collider.tag == "car") {
			Get.transform.Rotate(0,-90,0); 
			Get.transform.Translate (0, 0, -0.1f*Time.deltaTime);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
