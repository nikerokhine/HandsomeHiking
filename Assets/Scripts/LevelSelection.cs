﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void LoadLevel(int level){
		
		switch (level)
		{
		case 1:
			SceneManager.LoadScene ("Level1");
			break;
		case 2:
			SceneManager.LoadScene ("Level2");
			break;
		case 3:
			SceneManager.LoadScene ("Level3");
			break;
		case 4:
			SceneManager.LoadScene ("Level4");
			break;
		case 5:
			SceneManager.LoadScene ("Level5", LoadSceneMode.Single);
			break;
		case 6:
			SceneManager.LoadScene ("Level6");
			break;
		case 7:
			SceneManager.LoadScene ("Level7");
			break;
		case 8:
			SceneManager.LoadScene ("Level8");
			break;
		case 9:
			SceneManager.LoadScene ("Level9");
			break;
		default:
			Debug.Log ("This shouldn't happen");
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}