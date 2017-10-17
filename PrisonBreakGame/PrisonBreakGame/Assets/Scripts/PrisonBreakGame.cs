﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonBreakGame : MonoBehaviour {


	public Text myText;

	private enum States
	{
		cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom
	};

	private States myStates;

	// Use this for initialization
	void Start () {

		myStates = States.cell;
	}

	void Cell () {
	
		myText.text = "You are in a prison cell, and you want to escape. " +
			"There are " +  "some dirty sheets on the bed, a mirror on the wall, and " +
			"the door " + "is locked from the outside.\n\n" + "Press S to view Sheets," +
			" M to view Mirror and L to view Lock" ;
	}
		
	
	// Update is called once per frame
	void Update () {

		print (myStates);

		if (myStates == States.cell) 
		{
			Cell ();
		}
	}
}
