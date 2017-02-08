using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group : MonoBehaviour {


	private float lastFall = 0f;


	public static int UPDATERATE = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lastFall >= UPDATERATE) {
			transform.position = transform.position + Vector3.down;


			lastFall = Time.time;
		}

	}
}
