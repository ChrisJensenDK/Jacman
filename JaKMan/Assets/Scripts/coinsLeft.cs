using UnityEngine;
using System.Collections;

public class coinsLeft : MonoBehaviour {
	movePlayer coins;
	public Transform player;

	// Use this for initialization
	void Start () {
		coins = player.gameObject.GetComponent<movePlayer>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI()
	{	
		
		guiText.text = "Coins Left: "+coins.coinsLeft; 
		
	}
}
