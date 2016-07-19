using UnityEngine;
using System.Collections;

public class BuildingCtrl : MonoBehaviour {

	public GameObject DetailMenu;
	public UIButton BtnLotate;
	public UIButton BtnDelete;
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
	}



	void BuildingLotate() {
		if (me.name == "aa") {
			me.transform.Rotate (0, 90.0f, 0);
		}
	}

	void BuildingDelete() {
		if (me != null){ 
			if (me.name == "aa") {
				Destroy (me);
				//	Debug.Log (me);
			}
		}
	}
}
