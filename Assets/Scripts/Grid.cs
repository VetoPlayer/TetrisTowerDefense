using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : Singleton<Grid> {

	private Grid (){}


	//Grid dimensions
	public static int WEIGHT = 10;
	public static int HEIGHT = 10;

	// The grid is a bidimensional array of Transforms:

	public static Transform [,] grid = new Transform[WEIGHT,HEIGHT];
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}




	// Round vector method rounds any vector coordinates
	public static Vector2 roundVector(Vector2 vect){
		return new Vector2 (Mathf.Round(vect.x), Mathf.Round(vect.y));
	}


}
