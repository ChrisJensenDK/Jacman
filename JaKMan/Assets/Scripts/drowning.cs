using UnityEngine;
using System.Collections;

public class drowning : MonoBehaviour {
	healthBar health;

	public Transform exp; // enabling an "explosion" (the splash effect)
	
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "JakMan") {
			Instantiate (exp, transform.position, Quaternion.identity);
			health = other.gameObject.GetComponent<healthBar>();
			health.Life--;
			other.transform.position = health.startPos;
			
		}
	}
	
}
