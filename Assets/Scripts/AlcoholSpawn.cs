using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcoholSpawn : MonoBehaviour {

	public Transform spawnPos;
	public GameObject spawnee;
	public int frames;

	// Update is called once per frame
	void Update () {
		frames++;
		if (frames % 20 == 0) {
			Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
			frames = 0;
		}
	}
}