using UnityEngine;
using System.Collections;

public class MakeBuildings : MonoBehaviour {
		
	Vector3 mousePos;
	public GameObject Buildings;
	GameObject Building;
	float sWidth;
	float sHeight;
	float xx;
	float yy;
	float zz;
	Vector3 targetPosition;
		
	// Update is called once per frame
	void Update () {
		if (Building != null) {
			if (Input.GetButtonDown("Fire1")) {
				Debug.Log (22);
				targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				Instantiate(Buildings, targetPosition, transform.rotation);
				Debug.Log (targetPosition);
				}
			}
	}
	

	void GetMousePos () {
		
	}
	
	public void Make () {
		Building = (GameObject)Instantiate(Buildings, new Vector3 (0, 0, 0), transform.rotation);
		targetPosition = Building.transform.position;
	}


}
