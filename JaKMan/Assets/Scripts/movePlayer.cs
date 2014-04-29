using UnityEngine;
using System.Collections;

public class movePlayer : MonoBehaviour {
	
	public int playerspeed = 5; // Movement speed
	public int playerrotate = 100; // Rotation speed

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//Controls for the playable character (JakMan)
		
			if (Input.GetKey (KeyCode.W)) { // Move forward
				transform.Translate (Vector3.left * Time.deltaTime * playerspeed);
			}
				
			if (Input.GetKey (KeyCode.S)) { // Move backwards
				transform.Translate (Vector3.right * Time.deltaTime * playerspeed);
			}
		
			if (Input.GetKey (KeyCode.A)) { // Rotate left
				transform.Rotate (Vector3.down * Time.deltaTime * playerrotate);
			}
		
			if (Input.GetKey (KeyCode.D)) { // Rotate right
				transform.Rotate (Vector3.up * Time.deltaTime * playerrotate);
			}
				
	
	}
}
