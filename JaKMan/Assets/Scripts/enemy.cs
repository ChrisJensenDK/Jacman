using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	
<<<<<<< HEAD
	public Transform exp; // enabling an explosion


	// Use this for initialization
	void Start () {
	
=======
	public float rotSpeed = 150.0f; // rotation speed
	public Transform exp; // enabling an explosion

	// Use this for initialization
	void Start () {
		
>>>>>>> 2f787bbeba2b235cca402e5ac52a215f60699ffa
	}
	
	// Update is called once per frame
	void Update () {
<<<<<<< HEAD
		var speed: float = 3;
		var rotRange: float = 45; // random angle will be between -rotRange and rotRange
		var timeToChange: float = 5; // change direction each timeToChange seconds
		
		private var timer: float = 0; // start change timer
		
		function Update(){
			var controller : CharacterController = GetComponent(CharacterController);
			timer = timer - Time.deltaTime; // decrements timer counter
			if (timer
	}
	


=======
		transform.Rotate (new Vector3 (0, rotSpeed, 0) * Time.deltaTime);
	}
	
>>>>>>> 2f787bbeba2b235cca402e5ac52a215f60699ffa
	void OnCollisionEnter(Collision other){
		if(other.gameObject.name == "JakMan"){
			Instantiate (exp, transform.position, Quaternion.identity);
			Destroy (other.gameObject);
<<<<<<< HEAD
=======
			
>>>>>>> 2f787bbeba2b235cca402e5ac52a215f60699ffa
		}
	}
}
