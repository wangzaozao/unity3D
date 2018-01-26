﻿using UnityEngine;
using System.Collections;

public class Followbird : MonoBehaviour {

	private GameObject bird;
	private Transform birdTransform;

	// Use this for initialization
	void Start () {
		bird=GameObject.FindGameObjectWithTag("Player");
		birdTransform = bird.transform;
	}

	// Update is called once per frame
	void Update () {
		Vector3 birdPos = birdTransform.position;
		this.transform.position = new Vector3 (birdPos.x + 3.63223f, birdPos.y - 3.5088f, -10);
	}
}
