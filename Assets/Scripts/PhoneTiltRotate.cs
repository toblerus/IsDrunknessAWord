﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhoneTiltRotate : MonoBehaviour {

		// Use this for initialization
		void Start () {

			if(!Input.gyro.enabled)
			{
				Input.gyro.enabled = true;
			}
		}

		// Update is called once per frame
		void Update () 
		{
			transform.rotation  = Input.gyro.attitude;
		}
	
}
