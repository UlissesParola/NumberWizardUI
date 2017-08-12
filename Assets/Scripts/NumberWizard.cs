using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {

	int min;
	int max;
	int guess;
	int rounds;
	int maxGuesses;

	public Text text;

	// Use this for initialization
	void Start ()
	{
		StartGame();
	}
	
	// Update is called once per frame
	void Update () 
	{
						
	}

	public void GuessHigher()
	{
		min = guess + 1;
		Guess();
	}

	public void GuessLower()
	{
		max = guess;
		Guess();	
	}
				
	void Guess()
	{
		guess = Random.Range(min, max + 1);
		rounds++;

		if (rounds >= maxGuesses) {
			SceneManager.LoadScene ("Win");
		}

		if (guess > 1000) 
		{
			SceneManager.LoadScene ("Lose");
			return;
		}

		text.text = guess.ToString();
	}

	void StartGame()
	{
		min  = 1;
		max = 1000;
		rounds = 1;
		maxGuesses = GameData.maxGuesses;
		Guess ();
	}
}
