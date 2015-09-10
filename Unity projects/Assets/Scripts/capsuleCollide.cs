using UnityEngine;
using System.Collections;

public class capsuleCollide : MonoBehaviour {

	public PlayerController thePlayer;
	public ScoreController score;

	// Use this for initialization
	void Awake () {
		thePlayer = FindObjectOfType<PlayerController>();
		score = FindObjectOfType<ScoreController>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "Player")
		{
			thePlayer.points++;
			score.addNewPoints(thePlayer.points);
			Destroy(this.gameObject);
		}

	}
}
