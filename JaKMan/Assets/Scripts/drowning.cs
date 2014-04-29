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

	IEnumerator OnCollisionEnter(Collision other){
		if (other.gameObject.name == "JakMan") {
			yield return StartCoroutine(MyWaitFunction (0.0255f));
			health = other.gameObject.GetComponent<healthBar>();
			health.Life--;
			other.transform.position = health.startPos;
			
		}
	}

	IEnumerator MyWaitFunction (float delay){
		float timer = Time.time + delay;
		while (Time.time < timer) {
			yield return null;
		}
	}
}
