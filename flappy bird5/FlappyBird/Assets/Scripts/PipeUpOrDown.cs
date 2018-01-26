﻿using UnityEngine;
using System.Collections;

public class PipeUpOrDown : MonoBehaviour {

	public AudioSource hitMusic;
	public AudioSource dieMusic;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			hitMusic.Play();
			dieMusic.Play();
			GameManager._intance.GameState=GameManager.GAMESTATE_END;
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
