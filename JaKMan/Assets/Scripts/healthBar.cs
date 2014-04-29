using UnityEngine;
using System.Collections;

public class healthBar : MonoBehaviour {

	// Use this for initialization
	
	public int Life = 3;
    public Texture TextureHealth;
	public Vector3 startPos;
	
	void Start () {	
	 	startPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		    if(Life==0){
            	Application.LoadLevel (0);	
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