using UnityEngine;
using System.Collections;

public class LadderZone : MonoBehaviour 
{
	private float gravity = 0;
	private PlayerController thePlayer;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController>();	
		gravity = thePlayer.GetComponent<Rigidbody2D>().gravityScale;
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) 
	{
		if (other.name == "Player")
		{
			thePlayer.GetComponent<Rigidbody2D>().gravityScale = 0;
			thePlayer.onLadder = true;
			thePlayer.grounded = true;
		}
	}
	void OnTriggerExit2D (Collider2D other) 
	{
		if (other.name == "Player")
		{
			thePlayer.GetComponent<Rigidbody2D>().gravityScale = gravity;
			thePlayer.onLadder = false;
			thePlayer.grounded = false;
		}
	}
}
