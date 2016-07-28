using UnityEngine;
using System.Collections;

public class BuildingCtrl : MonoBehaviour {

	public GameObject DetailMenu;
	public UIButton BtnLotate;
	public UIButton BtnDelete;
	public UIButton BtnMoveUp;
	public UIButton BtnMoveDown;
	public UIButton BtnMoveLeft;
	public UIButton BtnMoveRight;
	private GameObject me;
	

	void OnMouseDown() {
		me = this.gameObject;
		Debug.Log (me);
		if (me.name == "aa") {
			//선택 되지 않은 상태
			DetailMenu.SetActive (false);
			me.name = "Building_House_014(Clone)";
			me.renderer.material.color = new Color(1.0f,1.0f,1.0f,0.5f);
		} else {
			// 선택된 상태
			me.name = "aa";
			DetailMenu.SetActive (true);
			me.renderer.material.color = Color.gray;
		} 

		BtnLotate.onClick.Add (new EventDelegate (BuildingLotate));
		BtnDelete.onClick.Add (new EventDelegate (BuildingDelete));
		BtnMoveUp.onClick.Add (new EventDelegate (BuildingMoveUp));
		BtnMoveDown.onClick.Add (new EventDelegate (BuildingMoveDown));
		BtnMoveLeft.onClick.Add (new EventDelegate (BuildingMoveLeft));
		BtnMoveRight.onClick.Add (new EventDelegate (BuildingMoveRight));
	}



	void BuildingLotate() {
		if (me.name == "aa") {
			me.transform.Rotate (0, 90.0f, 0);
		}
	}

	void BuildingMoveUp() {
		if (me.name == "aa") {

			if(me.transform.rotation.eulerAngles.y == 0)
				me.transform.Translate(0,0,1.0f);
			if(me.transform.rotation.eulerAngles.y == 90.00001f)
				me.transform.Translate(-1.0f,0,0);
			if(me.transform.rotation.eulerAngles.y == 180)
				me.transform.Translate(0,0,-1.0f);
			if(me.transform.rotation.eulerAngles.y == 270)
				me.transform.Translate(1.0f,0,0);
		}
	}

	void BuildingMoveDown() {
		if (me.name == "aa") {

			if(me.transform.rotation.eulerAngles.y == 0)
				me.transform.Translate(0,0,-1.0f);
			if(me.transform.rotation.eulerAngles.y == 90.00001f)
				me.transform.Translate(1.0f,0,0);
			if(me.transform.rotation.eulerAngles.y == 180)
				me.transform.Translate(0,0,1.0f);
			if(me.transform.rotation.eulerAngles.y == 270)
				me.transform.Translate(-1.0f,0,0);
		}
	}

	void BuildingMoveLeft() {
		if (me.name == "aa") {

			if(me.transform.rotation.eulerAngles.y == 0)
				me.transform.Translate(-1.0f,0,0);
			if(me.transform.rotation.eulerAngles.y == 90.00001f)
				me.transform.Translate(0,0,-1.0f);
			if(me.transform.rotation.eulerAngles.y == 180)
				me.transform.Translate(1.0f,0,0);
			if(me.transform.rotation.eulerAngles.y == 270)
				me.transform.Translate(0,0,1.0f);
		}
	}

	void BuildingMoveRight() {
		if (me.name == "aa") {
			if(me.transform.rotation.eulerAngles.y == 0)
				me.transform.Translate(1.0f,0,0);
			if(me.transform.rotation.eulerAngles.y == 90.00001f)
				me.transform.Translate(0,0,1.0f);
			if(me.transform.rotation.eulerAngles.y == 180)
				me.transform.Translate(-1.0f,0,0);
			if(me.transform.rotation.eulerAngles.y == 270)
				me.transform.Translate(0,0,-1.0f);
		}
	}

	void BuildingDelete() {
		if (me != null){ 
			if (me.name == "aa") {
				Destroy (me);
				DetailMenu.SetActive (false);
				//	Debug.Log (me);
			}
		}
	}
}
