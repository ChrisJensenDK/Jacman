using UnityEngine;
using System.Collections;

public class waterSound : MonoBehaviour {

	// Use this for initialization
	void Start () {
		audio.enabled = true;
	}
	
	public AudioClip Splash;
	
	void  OnCollisionEnter (Collision other){
		if(other.gameObject.name == "JakMan")
		{
			audio.PlayOneShot(Splash);
		}
	}
}
