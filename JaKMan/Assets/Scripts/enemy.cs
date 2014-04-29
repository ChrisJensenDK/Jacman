using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	
	public Transform exp; // enabling an explosion


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var speed: float = 3;
		var rotRange: float = 45; // random angle will be between -rotRange and rotRange
		var timeToChange: float = 5; // change direction each timeToChange seconds
		
		private var timer: float = 0; // start change timer
		
		function Update(){
			var controller : CharacterController = GetComponent(CharacterController);
			timer = timer - Time.deltaTime; // decrements timer counter
			if (timer
	}
	


	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "JakMan"){
			Instantiate (exp, transform.position, Quaternion.identity);
			Destroy (other.gameObject);
		}
	}
}
