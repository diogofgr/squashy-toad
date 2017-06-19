using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static MusicPlayer instance = null;

	void Awake() {
		if (instance != null) {
			// destroy new music player (keep previous):
//			Destroy (gameObject);
			Debug.Log ("Kept previous music player");
		}
		else {
			// create music player:			
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
			Debug.Log ("Created music player");
			Debug.Log (instance);
			Debug.Log (gameObject);
		}
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
