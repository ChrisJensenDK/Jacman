﻿using UnityEngine;
using System.Collections; 

[RequireComponent(typeof(CharacterController))]


public class movementEnemy : MonoBehaviour {
	
	public float speed = 5;
	public float directionChangeInterval = 1;
	public float maxHeadingChange = 30;
	private Vector3 enemyStart;

	CharacterController controller;
	float heading;
	Vector3 targetRotation;
	healthBar health;

	void Awake () {
		controller = GetComponent<CharacterController>();

		heading = Random.Range(0, 360);
		transform.eulerAngles = new Vector3(0, heading, 0);

		StartCoroutine(NewHeading());
	}
	
	// Use this for initialization
	void Start () {
		enemyStart = this.transform.position;

	}

	
	// Update is called once per frame
	void Update () {

		transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, targetRotation, Time.deltaTime * directionChangeInterval);
		var forward = transform.TransformDirection(Vector3.forward);
		transform.Translate(forward * speed);
		//controller.SimpleMove(forward * speed);
}


	/// Repeatedly calculates a new direction to move towards.
	/// Use this instead of MonoBehaviour.InvokeRepeating so that the interval can be changed at runtime.
	IEnumerator NewHeading ()
	{
		while (true) {
			NewHeadingRoutine();
			yield return new WaitForSeconds(directionChangeInterval);
		}
	}


	/// Calculates a new direction to move towards.
	void NewHeadingRoutine ()
	{
		var floor = Mathf.Clamp(heading - maxHeadingChange, 0, 360);
		var ceil  = Mathf.Clamp(heading + maxHeadingChange, 0, 360);
		heading = Random.Range(floor, ceil);
		targetRotation = new Vector3(0, heading, 0);
	}
	
	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "JakMan") {
			health = other.gameObject.GetComponent<healthBar>();
			health.Life--;
			other.transform.position = health.startPos;
			this.transform.position = enemyStart;
			
		}
	}
}