using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PhoneTiltRotate : MonoBehaviour {

	float zRotation;
	private int rotationValue;
	public Text leftrightvalue;
	public Text tiltvalue;
	float tiltvaluefloat;
	private int tiltvaluevar;


	void Start(){
		Input.gyro.enabled = false;
		Input.gyro.enabled = true;
	}
	void Update(){
		zRotation += -Input.acceleration.x;
		tiltvaluefloat = Input.acceleration.x;

		if (zRotation >= 0) 
		{
			transform.eulerAngles = new Vector3((zRotation), -90, 0);
			rotationValue = (int)zRotation;
			leftrightvalue.text = rotationValue.ToString ();
			tiltvaluevar = (int)tiltvaluefloat;
			tiltvalue.text = tiltvaluevar.ToString();
		}

		if (zRotation <= 0) 
		{
			transform.eulerAngles = new Vector3((zRotation), -90, 0);
			rotationValue = (int)zRotation;
			leftrightvalue.text = rotationValue.ToString ();
			tiltvaluevar = (int)tiltvaluefloat;
			tiltvalue.text = tiltvaluevar.ToString();
		}
	}

}
