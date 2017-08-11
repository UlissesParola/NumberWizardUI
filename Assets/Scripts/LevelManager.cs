using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	public void LoadLevel(string scene)
	{
		SceneManager.LoadScene(scene);
	}

	public void QuitRequest()
	{
		Debug.Log ("Quit requested");
	}
}
