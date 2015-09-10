using UnityEngine;
using System.Collections;

public class OpenHatch : MonoBehaviour {


	bool open = false;
	
	// Update is called once per frame
	void OnTriggerStay2D (Collider2D other) 
	{
		if (other.name == "Player")
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				//open hatch
				if (!open)
				{
					transform.localScale = new Vector3(2, 1, 1);
					GameObject.Find("Hatch").GetComponent<BoxCollider2D>().enabled = false;
					open = true;
				}
				else
				{
					transform.localScale = new Vector3(2, 0.1f, 1);
					GameObject.Find("Hatch").GetComponent<BoxCollider2D>().enabled = true;
					open = false;
				}
			}
		}
	}
}
