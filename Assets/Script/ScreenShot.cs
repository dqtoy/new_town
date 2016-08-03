using UnityEngine;
using System.Collections;

public class ScreenShot : MonoBehaviour {

	public UIButton BtnScreen;


	void Update() {

	}
	void OnClick() {
		Debug.Log (11);
		ScreenshotManager.SaveScreenshot("new_town","newTown");
		//BtnScreen.onClick.Add (new EventDelegate (takePicture));
	}
	void takePicture() {

	}
} 
  