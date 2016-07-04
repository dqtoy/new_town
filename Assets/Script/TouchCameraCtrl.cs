using UnityEngine;
using System.Collections;

public class TouchCameraCtrl : MonoBehaviour {

	public float moveSensitivityX = 3.0f;
	public float moveSensitivityY = 3.0f;
	public bool updateZoomSensitivity = true;
	public float orthoZoomSpeed = 0.05f;
	public float perspectiveZoomSpeed = .5f;
	public float minZoom = 1.0f;
	public float maxZoom = 20.0f;
	public bool invertMoveX = false;
	public bool invertMoveY = false;
	

	// Update is called once per frame
	void Update () {
		if (updateZoomSensitivity) {
			moveSensitivityX = camera.fieldOfView / 5.0f;
			moveSensitivityY = camera.fieldOfView / 5.0f;
		}

		Touch[] touches = Input.touches;

		if (touches.Length > 0) {
			// 싱글 터치 이동
			if(touches.Length == 1) {
				if (touches[0].phase == TouchPhase.Moved) {
					Vector2 delta = touches[0].deltaPosition;

					float positionX = delta.x * moveSensitivityX * Time.deltaTime;
					positionX = invertMoveX ? positionX : positionX * -1;

					float positionY = delta.y * moveSensitivityY * Time.deltaTime;
					positionY = invertMoveY ? positionY : positionY * -1;

					camera.transform.position += new Vector3(positionX,positionY,0);

				}
			}
			// 터치 두개 줌인
			if(touches.Length == 2) {
				Touch touchOne = touches[0];
				Touch touchTwo = touches[1];

				Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
				Vector2 touchTwoPrevPos = touchTwo.position - touchTwo.deltaPosition;

				float prevTouchDeltaMag = (touchOnePrevPos - touchTwoPrevPos).magnitude;
				float touchDeltaMag = (touchOne.position - touchTwo.position).magnitude;

				float deltaMagDiff = prevTouchDeltaMag - touchDeltaMag;

				camera.fieldOfView += deltaMagDiff * perspectiveZoomSpeed;
				camera.fieldOfView = Mathf.Clamp(camera.fieldOfView, .1f, 179.9f);
			}
		}
	}
}
