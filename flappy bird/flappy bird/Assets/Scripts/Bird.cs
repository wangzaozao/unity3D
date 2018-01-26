using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	public float timer=0;
	public int frameNumber=10;//frame number one second
	public int frameCount=0;//frame counter

	// Use this for initialization
	void Start () {
	//	this.GetComponent<Rigidbody>().velocity = new Vector3 (5, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody>().velocity = new Vector3 (5, 0, 0);
		timer+= Time.deltaTime;
		if (timer>= 1.0f / frameNumber) {
			frameCount++;
			timer-=1.0f/frameNumber;
			int frameIndex=frameCount%3;
			//how to set the property of(x offset)  MainText:Main Texture
			this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex",new Vector2(0.33333f*frameIndex,0));
	}
	}
}
