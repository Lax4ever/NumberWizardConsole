using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int min;  
	int max;	
	int guess;

	void Start () {StartGame ();}

	void StartGame () {
		
		min = 1;
		max = 1000;
		
		print ("Welcome to Number Wizard!");
		print ("Pick a number between " + min + " and " + max + ".");
		print ("DON'T TELL ME!");
		print ("I will try and guess the number.");
		print ("Press UP for higher, DOWN for lower, and RETURN for a correct guess.");

		min = 0;
		guess = Random.Range (min, max);

		print ("Is your number " + guess + "?");
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			NextGuess ();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Winner!");
			StartGame ();
		}

	}

	void NextGuess () {
		guess = Random.Range (min, max);
		print ("Is your number " + guess + "?");
	}

}
