﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using System.Collections;

public class MainMenu : MonoBehaviour {

	private Button easyButton;
	private Button hardButton;
	private GameObject player;

	public bool isHard = true;

	// Use this for initialization
	void Start () {
		Object.DontDestroyOnLoad (this);
		Scene scene = SceneManager.GetActiveScene();
		if (scene.name == "MainMenu") {
			easyButton = GameObject.Find ("Easy").GetComponent<Button> ();
			hardButton = GameObject.Find ("Hard").GetComponent<Button> ();
			easyButton.onClick.AddListener (loadEasy);
			hardButton.onClick.AddListener (loadHard);
		}

		SceneManager.sceneLoaded += getPlayerObject();
		SceneManager.sceneUnloaded += getScore();
	}

	 public void getPlayerObject() {
		Debug.Log ("Hello");
	}

	public void getScore() {
		Debug.Log ("Goodbye");
	}

	void loadEasy() {
		isHard = false;
		MoveToMainScene ();
	}

	void loadHard() {
		isHard = true;
		MoveToMainScene ();
	}

	void MoveToMainScene() {
		SceneManager.LoadScene ("MainScene");
	}

}
