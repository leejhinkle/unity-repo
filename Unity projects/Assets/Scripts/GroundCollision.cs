using UnityEngine;
using System.Collections;

public class GroundCollision : MonoBehaviour {

	// Use this for initialization
	private PlayerController thePlayer;
	// Use this for initialization
	void Start () 
	{
		thePlayer = FindObjectOfType<PlayerController>();	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.name == "Player")
		{
			thePlayer.grounded = true;
		}
	}
	void OnTriggerStay2D (Collider2D other) 
	{
		if (other.name == "Player")
		{
			thePlayer.grounded = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) 
	{
		if (other.name == "Player")
		{
			thePlayer.grounded = false;
		}
	}
}
