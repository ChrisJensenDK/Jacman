using UnityEngine;
using System.Collections;

public class score : MonoBehaviour
{
	
	double Counter = 1000000;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		Counter -=100;
	
	}
	void OnGUI()
	{	
	
		guiText.text = "Score: "+Counter; 
			
	}
}