using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	
	public float rotSpeed = 150.0f; // rotation speed
	public Transform exp; // enabling an explosion

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, rotSpeed, 0) * Time.deltaTime);
	}
	
	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "JakMan"){
			Instantiate (exp, transform.position, Quaternion.identity);
			Destroy (other.gameObject);
			
		}
	}
}
