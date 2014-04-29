using UnityEngine;
using System.Collections;

public class coinSound : MonoBehaviour {


	void Start(){
		audio.enabled = true;
	}

	public AudioClip Coin;
	
	void  OnCollisionEnter (Collision other){
		if(other.gameObject.name == "JakMan")
		{
			audio.PlayOneShot(Coin);
		}
	}
}