using UnityEngine;
using System.Collections;



public class score : MonoBehaviour
{
	double Counter = 50000;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		Counter -=5;

		if(Counter==0){
			Application.LoadLevel (2);
		}
	
	}
	void OnGUI()
	{	
	
		guiText.text = "Score: "+Counter; 
			
	}
}