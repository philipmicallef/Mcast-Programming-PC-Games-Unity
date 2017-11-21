﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	public void LoadNextLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}


	public void BrickDestroyed()
	{
		//calling stsic variable breakableCount
		if (Brick.breakableCount <= 0) 
		{
			LoadNextLevel();
		}
	}

	public void QuitGame()
	{
		UnityEditor.EditorApplication.isPlaying = false;	
	}
		
	public void LoadLevel(string levelName)
	{
		print ("Loading level" + levelName);
		// loads the Scene named levelName

		SceneManager.LoadScene(levelName);
	}

}
