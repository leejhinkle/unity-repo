using UnityEngine;
using System.Collections;

public class StayOnPlatform : MonoBehaviour {

	//when something collides with ushort, Weapon become it's parent
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.name == "Player")
		{
			col.transform.parent = gameObject.transform;
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{
		if (col.name == "Player")
		{
			col.transform.parent = null;
		}
	}
}
