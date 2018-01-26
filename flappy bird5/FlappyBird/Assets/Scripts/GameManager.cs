using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	//define the state of the game
	public static int GAMESTATE_MENU          =0;
	public static int GAMESTATE_PLAYING       =1;
	public static int GAMESTATE_END           =2;

	public Transform firstBg;
	public int score=0;
	public int GameState = GAMESTATE_MENU;

	public static GameManager _intance;

	private GameObject bird;

	void Awake(){
		_intance = this;
		bird=GameObject.FindGameObjectWithTag("Player");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameState == GAMESTATE_MENU) {
			if(Input.GetMouseButtonDown(0)){
				//transform state
				GameState = GAMESTATE_PLAYING;
				//set bird is playing
				//1.set gravity 2.add velocity
				bird.SendMessage("getLife");
			}
		}
	
	}
}
