using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {


	public LevelManager myLevelManager;

	// is called when objects collide together
	void OnCollisionEnter2D(Collision2D collision)
	{
		print ("Collison with "+ collision.gameObject.name);

	}

	// is called when object passes through collider
	void OnTriggerEnter2D (Collider2D collision)
	{
		myLevelManager.LoadLevel("Win");
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
