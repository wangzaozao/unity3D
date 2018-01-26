using UnityEngine;
using System.Collections;

public class MoveTrigger : MonoBehaviour {

	public Transform currentBg;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
		//move the bg to the front of first transform
		//1.get the first transform
		Transform firstBg= GameManager._intance.firstBg;
		//2.move
			currentBg.position=new Vector3(firstBg.position.x+10,currentBg.position.y,currentBg.position.z);

			GameManager._intance.firstBg=currentBg;
		}
	}
}
