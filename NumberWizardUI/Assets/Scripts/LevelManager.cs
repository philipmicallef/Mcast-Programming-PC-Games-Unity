using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	public void Quit()
	{
		UnityEditor.EditorApplication.isPlaying = false;	
	}






	public void Loadlevel(string levelName)
	{
		print ("Loading level" + levelName);
		// loads the Scene named levelName

		SceneManager.LoadScene(levelName);
	}

}
