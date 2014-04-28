using UnityEngine;
using System.Collections;

public class score : MonoBehaviour
{
	
	double Counter = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		Counter +=25;
	
	}
	void OnGUI()
	{	
	
		guiText.text = "Score: "+Counter; 
			
	}
}