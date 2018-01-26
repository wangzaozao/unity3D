using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform firstBg;

	public static GameManager _intance;

	void Awake(){
		_intance = this;
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
