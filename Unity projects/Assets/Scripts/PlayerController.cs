using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float jump;
	public float speed;
	public float moveVelocity;
	public bool onLadder;
	public bool isOnPlatform;

	public bool grounded = true;
	bool sprinting = false;

	public int points = 0;

	public ScoreController score;
	public Weapon weapon;

	void Start()
	{
		score = FindObjectOfType<ScoreController>();

	}


	// Update is called once per frame
	void Update () {

		moveVelocity = 0;

		//check sprinting
		if (Input.GetKey(KeyCode.LeftShift))
		{
			sprinting = true;
		}
		else
		{
			sprinting = false;
		}





		//**********
		//you need to take this and make it move left and right
		//tell me what process you used to get it to work

		//Description of what code does
		//actual inputCodehere

		//Move right--D indicates Right
		//Vector2 takes x, y as input to change object location along the path
		//want to keep y movement according to Y key (W), so just copy ".velocity.y"
		//from object
		if (Input.GetKey(KeyCode.D))
		{
			/*if(grounded)  //logical equicvalent to "grounded == true"
			{*/
			/*GetComponent*/
				moveVelocity = speed;
			//flip code
			//}
			/*else
			{
				GetComponent<Rigidbody2D>().velocity = 
					new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y);
			}*/
		}

		if (Input.GetKey(KeyCode.A))
		{
			//if(grounded && GetComponent<Rigidbody2D>().position.x > 1.0)  //logical equicvalent to "grounded == true"
			//{
				moveVelocity = -speed;
			//}
		}
		if (sprinting)
		{
			moveVelocity *= 2;  //equivalent to moveVelocity = moveVelocity * 2;
		}


		/*if moveVelocity < 0
		{
			GetComponent<Rigidbody2D>().
		}*/
		if ((onLadder) && (Input.GetKey(KeyCode.W))) //on ladder and holding up
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speed);
		}
		else if ((onLadder) && (Input.GetKey(KeyCode.S))) //on ladder and holding down
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, -speed);
		}
		else if (onLadder) //on ladder and not moving
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
		}
		else //not on ladder
		{
			//jump
			//jump code--changes vertical state
			if (Input.GetKeyDown(KeyCode.W))
			{
				if(grounded)  //logical equivalent to "grounded == true"
				{
					GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jump);
					//if 
				}
			}
		}

		//move right left code
		GetComponent<Rigidbody2D>().velocity = 
			new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);
		/*
		if (!grounded && Input.GetKeyDown(KeyCode.Space))
		{
			//create a laser to shoot down
		}
	*/

		if(Input.GetMouseButtonDown(0))
		{
			points++;
			score.addNewPoints(points);
		}

	}



}
