using UnityEngine;
using System.Collections;

public class coin : MonoBehaviour {

	public Transform exp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, 2.0f);
	}

	void OnCollisionEnter (Collision other){
		if(other.gameObject.name == "JakMan") {
			Destroy(this.gameObject);
		}
	}
}
