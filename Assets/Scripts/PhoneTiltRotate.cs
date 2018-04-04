using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PhoneTiltRotate : MonoBehaviour {

	float zRotation;
	private int rotationValue;
	public Text Text;

	void Start(){
		Input.gyro.enabled = false;
		Input.gyro.enabled = true;
	}
	void Update(){
		zRotation += -Input.gyro.rotationRateUnbiased.z;


		if (zRotation >= 0) 
		{
			transform.eulerAngles = new Vector3((zRotation - (2*zRotation)), -90, 0);
			rotationValue = (int)zRotation;
			Text.text = rotationValue.ToString ();
		}

		if (zRotation <= 0) 
		{
			transform.eulerAngles = new Vector3((zRotation * -1), -90, 0);
			rotationValue = (int)zRotation;
			Text.text = rotationValue.ToString ();
		}
	}
	
}
