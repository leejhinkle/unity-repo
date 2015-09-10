using UnityEngine;
using System.Collections;

public class MovePlatform : MonoBehaviour {

	public Transform movingPlatform;
	public Transform position1;
	public Transform position2;
	public Vector3 newPosition;
	public string currentState; //creation of state machine
	public float smooth;
	public float resetTime;
	public bool moving;

	void Start()
	{
		ChangeTarget();
	}

	//always runs, even if FPS drops
	void FixedUpdate()
	{
		if (moving)
		{
			movingPlatform.position = Vector3.Lerp(movingPlatform.position, newPosition, smooth * Time.deltaTime);
		}
	}

	void ChangeTarget()
	{

		if(currentState == "moving to position 1")
		{
			currentState = "moving to position 2";
			newPosition = position2.position;
		}
		else if (currentState == "moving to position 2")
		{
			currentState = "moving to position 1";
			newPosition = position1.position;
		}
		else if(currentState == "")
		{
			currentState = "moving to position 2";
			newPosition = position2.position;
		}
		Invoke("ChangeTarget", resetTime);

	}
}
