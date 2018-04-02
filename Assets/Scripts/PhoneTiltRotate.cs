using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhoneTiltRotate : MonoBehaviour {

	float zRotation;
	void Start(){
		Input.gyro.enabled = false;
		Input.gyro.enabled = true;
	}
	void Update(){
		zRotation += -Input.gyro.rotationRateUnbiased.z;

		transform.eulerAngles = new Vector3(0, -90, zRotation);

	}
	
}
