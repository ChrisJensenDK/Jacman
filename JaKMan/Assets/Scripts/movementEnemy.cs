﻿using UnityEngine;
using System.Collections;

public class movementEnemy : MonoBehaviour {

	var stuff : Transform; // Note: rigidbody must be activated with the collider for this to work
	var vel : Vector3; // Holds the random velocity
	var switchDirection : float = 3;
	var curTime : float = 0;

	// Use this for initialization
	void Start () {
		SetVel();
	}

	function SetVel(){
		if (Random.value > .5){
		vel.x = 10 * 10 * Random.value;
		}
		else {
			vel.x = -10 * -10 * Random.value;
		}
		if (Random.value > .5) {
			vel.z = -10 * -10 * Random.value;
		}
		else {
			vel.z = -10 * 10 * Random.value;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (curTime < switchDirection) {
			curTime += 1 * Time.deltaTime;
		}
		else {
			SetVel ();
			if (Random.value > .5) {
				switchDirection += Random.value;
			}
			else {
				switchDirection -= Random.value;
			}
			if (switchDirection < 1) {
				switchDirection = 1 + Random.value;
			}
			curTime = 0;
		}
	
	}

	function FixedUpdate() {
		stuff.rigidbody.velocity = vel;
	}
}
