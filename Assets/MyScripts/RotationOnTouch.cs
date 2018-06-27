using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationOnTouch : MonoBehaviour {

	void Update () {

		if (Input.touchCount > 0) { 

			for (int i = 0; i < Input.touchCount; i++) {

				if (i > 0) {
					if (Input.GetTouch(i).phase == TouchPhase.Stationary
						&& Input.GetTouch(i - 1).phase == TouchPhase.Stationary
						&& Input.GetTouch(i).position.y < Screen.width/2) {
						transform.localScale -= new Vector3(0.01F, 0.01F, 0.01F);
						break; 
					}

					if (Input.GetTouch (i).phase == TouchPhase.Stationary
						&& Input.GetTouch (i - 1).phase == TouchPhase.Stationary
						&& Input.GetTouch (i).position.y > Screen.width/2) { 
						transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);
						break;
					}
				}

				if (Input.GetTouch(i).phase == TouchPhase.Stationary 
					&& Input.GetTouch(i).position.y < Screen.width/2) {
					transform.Rotate(0, -20 * Time.deltaTime, 0); 
				} 

				if (Input.GetTouch(i).phase == TouchPhase.Stationary
					&& Input.GetTouch(i).position.y > Screen.width/2) {
					transform.Rotate (0, 20 * Time.deltaTime, 0); 
				}
			} 
		} 
	}
}
