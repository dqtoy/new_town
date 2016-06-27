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
	Vector3 aa;
		
	// Update is called once per frame
	void Update () {
		if (Building != null) {
			if (Input.GetButtonDown("Fire1")) {
				targetPosition = Input.mousePosition;
				RaycastHit rayHit;
				if(Physics.Raycast(Camera.main.ScreenPointToRay(targetPosition), out rayHit)) {
					aa = rayHit.point;
					Debug.Log (aa);
					Instantiate(Buildings, aa, transform.rotation);
				}


				//Debug.Log (targetPosition);
				}
			}
	}

	
	public void Make () {
		Building = (GameObject)Instantiate(Buildings, new Vector3 (0, 0, 0), transform.rotation);
		targetPosition = Building.transform.position;
	}


}
