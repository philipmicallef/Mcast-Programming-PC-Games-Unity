using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour 
{


	// Storing a max and a min value
	int min = 1;
	int max = 1001;
	int guess = 500;
	int maxNumberOfTries = 10;

	public Text guessText;

	public void GuessLower()
	{
		max = guess;
		NextGuess ();

	}

	public void GuessHigher()
	{
		min = guess;
		NextGuess ();
	}


	void NextGuess()
	{
		//guess = (max + min) / 2; // Guesses by halfing the number

		guess = Random.Range (min, max); // Random Guessing between Min and Max


		guessText.text = guess.ToString ();

		maxNumberOfTries--;

		if (maxNumberOfTries == 0) // if AI does not guess the number, the player wins 
		{
			SceneManager.LoadScene ("Win");
			guess = 500;
		}

	}


	// Use this for initialization
	void Start () 
	{
		guess = Random.Range (min, max);
		guessText.text = guess.ToString ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
