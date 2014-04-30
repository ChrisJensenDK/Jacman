using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(412,350,200,100), "Start Game")) {
			Application.LoadLevel(1);
		}
		
		// Make the second button.
		if(GUI.Button(new Rect(412,500,200,100), "Quit")) {
			Application.Quit();
		}
	}
}
