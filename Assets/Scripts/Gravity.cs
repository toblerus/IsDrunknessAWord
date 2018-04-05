using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
	public float leftrightRotation;
	public Quaternion rotation = Quaternion.identity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		leftrightRotation = (rotation.eulerAngles.x);
	}
}
