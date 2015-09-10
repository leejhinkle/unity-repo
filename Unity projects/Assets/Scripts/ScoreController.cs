using UnityEngine;
using System.Collections;

public class ScoreController : MonoBehaviour {

	//public PlayerController thePlayer;
	// Use this for initialization
	void Start () {
		//thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	public void addNewPoints(int points) 
	{
		this.guiText.text = "Score: " + points;
		GetComponent<GUIText>().text = "Score: " + points;
	}
}
