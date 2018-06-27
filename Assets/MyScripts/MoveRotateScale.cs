using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

// Cyborg script 
public class MoveRotateScale : MonoBehaviour {

	public GameObject target; // 2nd Image Target 
	Vector3 prevTargetPos; 
	Quaternion prevTargetRot; 


	void Start () {

		prevTargetPos = target.transform.position;   
		prevTargetRot = target.transform.rotation; 
	}

	// smoother 
	void FixedUpdate () {

			// translation 
			Vector3 tempPos = target.transform.position - prevTargetPos; // by how much did it move? 
			transform.position += tempPos;
			
			// rotation 
			Quaternion tempRot = target.transform.rotation * Quaternion.Inverse(prevTargetRot); // by how much did it rotate? 
			transform.rotation = tempRot * transform.rotation; 

			// reset 
			prevTargetPos = target.transform.position;
			prevTargetRot = target.transform.rotation; 

	
	}
}

/* 
 * Scale 
 * 
 * if ((target.transform.position.z - prevTargetPos.z > 0.1) && Input.GetKey("2")) { 
	Debug.Log("Z"); 
	transform.localScale += new Vector3(0.02F, 0.02F, 0.02F); 
}

if ((target.transform.position.z - prevTargetPos.z < -0.1) && Input.GetKey("2")) {
	Debug.Log("-Z"); 
	transform.localScale -= new Vector3(0.02F, 0.02F, 0.02F); 
} 
*/ 