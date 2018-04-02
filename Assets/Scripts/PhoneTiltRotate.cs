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
		transform.eulerAngles = new Vector3(zRotation, -90, 0);
		rotationValue = (int)zRotation;
		Text.text = rotationValue.ToString ();
	}
	
}
