using UnityEngine;
using System.Collections;

public class drowning : MonoBehaviour {

	public Transform exp; // enabling an "explosion" (the splash effect)
	public Texture TextureHealth;
	public int Life = 1;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Life==0){
          Application.LoadLevel (0);
		}
	
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == "JakMan") {
			Instantiate (exp, transform.position, Quaternion.identity);
			Life--;
		}
	}
	
		void OnGUI(){
	    if ( Life!=0){
	            for (int i=0; i<Life; i++){
	                  int posX = 50+50*i;
	                  GUI.DrawTexture(new Rect(posX,30,30,30),TextureHealth);
				}
	
		}
	}
}
