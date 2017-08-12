using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultHandler : MonoBehaviour {

	public Text difficult;
	// Use this for initialization
	void Start () {
		GameObject[] gameObjects = SceneManager.GetSceneByName ("Game").GetRootGameObjects ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Easy()
	{
		difficult.text = "Easy";
		GameData.maxGuesses = 8;
	}

	public void Normal()
	{
		difficult.text = "Normal";
		GameData.maxGuesses = 13;
	}

	public void Hard()
	{
		difficult.text = "Hard";
		GameData.maxGuesses = 18;
	}
		
}
