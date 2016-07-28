using UnityEngine;
using System.Collections;

public class MakeBuildings : MonoBehaviour {
		
	Vector3 mousePos;
	public GameObject Buildings;
	GameObject Building;
	GameObject Building1;
	float sWidth;
	float sHeight;
	float xx;
	float yy;
	float zz;
	Vector3 targetPosition;
	Vector3 aa;
	public GameObject DetailMenu;
	public UIButton BtnLotate;
	public UIButton BtnDelete;
	public UIButton BtnMoveUp;
	public UIButton BtnMoveDown;
	public UIButton BtnMoveLeft;
	public UIButton BtnMoveRight;
		
	// Update is called once per frame
	void Update () {
		if (Building != null) {
			if (Input.GetButtonDown("Fire1")) {

				targetPosition = Input.mousePosition;
				RaycastHit rayHit;
				if(Physics.Raycast(Camera.main.ScreenPointToRay(targetPosition), out rayHit)) {
					if(rayHit.collider.name == "grass_square_mesh") {
						Building = null;
						aa = rayHit.point;
						Building1 = (GameObject)Instantiate(Buildings, aa, transform.rotation);
						BuildingCtrl buildingCtrl = Building1.GetComponent<BuildingCtrl>();
						buildingCtrl.DetailMenu = DetailMenu;
						buildingCtrl.BtnLotate = BtnLotate;
						buildingCtrl.BtnDelete = BtnDelete;
						buildingCtrl.BtnMoveUp = BtnMoveUp;
						buildingCtrl.BtnMoveDown = BtnMoveDown;
						buildingCtrl.BtnMoveLeft = BtnMoveLeft; 
						buildingCtrl.BtnMoveRight = BtnMoveRight;
					}

				}

				//Debug.Log (targetPosition);
				}
			}
	}

	
	public void Make () {
		Building = (GameObject)Instantiate(Buildings, new Vector3 (0, 0, 0), transform.rotation);
		//targetPosition = Building.transform.position;
	}


}
