using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PhoneTiltRotate : MonoBehaviour {

	float zRotation;
	private int rotationValue;
	public Text zRotationValueDisp;

	void Start(){
		Input.gyro.enabled = false;
		Input.gyro.enabled = true;
	}
	void Update(){
		zRotation += -Input.gyro.rotationRateUnbiased.x;


		if (zRotation >= 0) 
		{
			transform.eulerAngles = new Vector3((zRotation - (2*zRotation)), -90, 0);
			rotationValue = (int)zRotation;
			zRotationValueDisp.text = rotationValue.ToString ();
		}

		if (zRotation <= 0) 
		{
			transform.eulerAngles = new Vector3((zRotation * -1), -90, 0);
			rotationValue = (int)zRotation;
			zRotationValueDisp.text = rotationValue.ToString ();
		}
	}
	
}
