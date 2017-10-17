using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour 
{


	// Storing a max and a min value
	int max;
	int min;
	int guess;


	void NextGuess()
	{
		print ("Is the number bigger or smaller than " + guess + " ?");
		print("Press UP if number is bigger");
		print("Press DOWN if number is smaller");
		print("Press ENTER if number is guessed");
	}



	void StartGame()
	{
		min = 1;
		max = 1001;
		guess = 500;

		// Outputting a message to user
		print("Welcome to Number Wizard");

		// Debug.Log is the same as print
		// String Concatination - adding the named variables min and max into the sentence
		Debug.Log("please choose a number from " + min + " to " + max);
		NextGuess();
	}


	// Use this for initialization
	void Start () 
	{
		StartGame ();
	}
	
	// Update is called once per frame
	void Update () 
	{


		//Setting actions for keys pressed
		if(Input.GetKeyDown(KeyCode.UpArrow)) 
		{
			Debug.Log("UP Pressed");
			min = guess;
			guess = (max + min) / 2;
			NextGuess();
		}

		else 

		if(Input.GetKeyDown(KeyCode.DownArrow)) 
		{
			Debug.Log("Down Pressed");
			max = guess;
			guess = (max + min) / 2;
			NextGuess();
		}

		else

		if(Input.GetKeyDown(KeyCode.Return)) 
		{
			Debug.Log("Enter Pressed");
			Debug.Log("Number Guessed");
			print("(P)lay Again or (Q)uit");

			if (Input.GetKeyDown (KeyCode.Q)) 
			{
				UnityEditor.EditorApplication.isPlaying = false;
			}

			else
				if(Input.GetKeyDown(KeyCode.P))
			{
				StartGame();			
			}
		}
	}
}
