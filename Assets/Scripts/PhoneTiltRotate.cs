using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhoneTiltRotate : MonoBehaviour {

	float xRotation;
	void Start(){
		Input.gyro.enabled = false;
		Input.gyro.enabled = true;
	}
	void Update(){
		xRotation += -Input.gyro.rotationRateUnbiased.x;

		transform.eulerAngles = new Vector3(0, -90, xRotation);

	}
	
}
