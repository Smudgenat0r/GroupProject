using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (camera.transform.position.x > -21 && camera.transform.position.x < 21) {
			float xAxisVal = Input.GetAxis ("Horizontal");
			camera.transform.Translate (new Vector3 (xAxisVal, 0.0f, 0.0f));
		}
		if (camera.transform.position.x < -21)
			camera.transform.Translate (new Vector3 (1.0f, 0.0f, 0.0f));
		if (camera.transform.position.x > 21)
			camera.transform.Translate (new Vector3 (-1.0f, 0.0f, 0.0f));
	}
}
