using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	private Ball myBall;

	// Use this for initialization
	void Start () {

		myBall = GameObject.FindObjectOfType<Ball> ();
	}
	
	// Update is called once per frame
	void Update () {

		//save the position in Unity units (depending on the number of units on screen)
		float mousePosInUnits = (Input.mousePosition.x / Screen.width * 13f) - 6.5f;

		// creates a Vector3 which saves a coordinate in (X,Y,Z)
		//this.transform.position.y --> locks the Y postion to the starting Y postion of the paddle
		Vector3 paddlePosition = new Vector3 (2f, this.transform.position.y, 0f);

		//make the paddle move with the mouse


		//paddlePosition.x = Mathf.Clamp(mousePosInUnits,-6.5f, 6.5f);

		paddlePosition.x = Mathf.Clamp(myBall.transform.position.x,-6.5f, 6.5f);

		//set the position of the paddle (this) to paddlePosition
		this.transform.position = paddlePosition;
	}
}
