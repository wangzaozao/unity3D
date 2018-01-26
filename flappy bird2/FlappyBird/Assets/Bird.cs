using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {

	public float timer=0;
	public int frameNumber=10;//frame num one seconds
	public int frameCount=0;// frame counter
	  
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer+=Time.deltaTime;
		if (timer >= 1.0f / frameNumber) {
			frameCount++;
			timer-=1.0f/frameNumber;
			int frameIndex=frameCount%3;
			//update material's offset x
			//how to set the property of(x offset) MainTex:Main Texture
			this.GetComponent<Renderer>().material.SetTextureOffset("_MainTex",new Vector2(0.333333f*frameIndex,0));
		}
	}
}
