using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer myMusicPlayer = null;


	void Awake() // the first method that is run in Unity
	{
		// if myMusicPlayer is the 1st instance
		if (myMusicPlayer == null) 
		{
			//myMusicPlayer = 1st SoundObject
			myMusicPlayer = this;

			//this.gameObject = the gameObject attached to this script, in our case its SoundObject
			//DontDestroyOnLoad = do not destroy the gameObject when changing scenes
			GameObject.DontDestroyOnLoad (this.gameObject);
		}

		//if myMusicPlayer is NOT null
		// if a SoundObject already exists
		else
		{
			print ("Sound object" + this.gameObject.GetInstanceID ().ToString ());
			print("First Sound Object");

			//Destroy the 2nd gameObject created
			Destroy (this.gameObject);
		}
	}


	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
