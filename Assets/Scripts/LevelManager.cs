﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
//		Brick.numberOfBreakableBricks = 0;
		SceneManager.LoadScene(name);
	}

	public void QuitGame(){
		print ("Quit game requested");
		Application.Quit();

	}

	public void LoadNextLevel(){
//		Brick.numberOfBreakableBricks = 0;
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}
