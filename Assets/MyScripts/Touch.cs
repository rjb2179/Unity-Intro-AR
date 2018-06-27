using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

	public Material material; 

	void Start () {
		material.SetColor ("_Color", Color.blue); 
	}

	void Update () {

		if (Input.touchCount > 0) { 

			foreach (UnityEngine.Touch touch in Input.touches) {

				// create ray from current touch coordinates 
				Ray ray = Camera.main.ScreenPointToRay(touch.position); 
				RaycastHit hit; 

				if (Physics.Raycast (ray, out hit)) {

					if (hit.collider != null) {
						material.SetColor("_Color", Color.red);
					}
				}
			}
		}
	}
}
