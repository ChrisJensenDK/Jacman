using UnityEngine;
using System.Collections;

public class coinSound : MonoBehaviour {

	public AudioClip Coin;
	
	void  OnCollisionEnter (Collision other){
		if(other.gameObject.name == "JakMan")
		{
			audio.PlayOneShot(Coin);
		}
	}
}