using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour {

	//adjust this to change speed
	float speed = 2.5f;
	//adjust this to change how high it goes
	float xval = 0.5f;

	void Update() {
		//get the objects current position and put it in a variable so we can access it later with less code
		Vector3 pos = transform.position;
		//calculate what the new X position will be
		float newX = Mathf.Sin(Time.time * speed);
		//set the object's X to the new calculated Y
		transform.position = new Vector3(newX + - 5f, pos.y, pos.z); 
	}
}
