using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {
	public void RandomGeneratePosition(){
	//how to random a number
		float pos_y = Random.Range (-0.4f, -0.1f);
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x, pos_y, this.transform.localPosition.z);
	}
	// Use this for initialization
	void Start () {
		RandomGeneratePosition ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
