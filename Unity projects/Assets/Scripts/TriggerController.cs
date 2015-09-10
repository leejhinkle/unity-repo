using UnityEngine;
using System.Collections;

public class TriggerController : MonoBehaviour {
	
	private MovePlatform[] platforms;

	// Use this for initialization
	void Start () {
		platforms = FindObjectsOfType<MovePlatform>();
	}

	// Update is called once per frame
	void OnTriggerStay2D (Collider2D other) 
	{
		if (other.name == "Player")
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				//open hatch
				//for all moving platforms
				foreach (MovePlatform platform in platforms)
				{

					if (platform != null)
					{
						if (platform.moving == false)
						{
							platform.moving = true;	
						}
						else
						{
							platform.moving = false;
						}


					}
				}
			}
		}
	}
}
