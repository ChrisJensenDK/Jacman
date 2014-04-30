using UnityEngine;
using System.Collections;



public class score : MonoBehaviour
{
	double counter = 50000;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		counter -=5;
		if(counter==0){
			Application.LoadLevel (2);
		}
	
	}
	void OnGUI()
	{	
	
		guiText.text = "Score: "+counter; 
			
	}
}