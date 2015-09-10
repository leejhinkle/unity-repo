using UnityEngine;
using System.Collections;

public class SmoothCamera2D : MonoBehaviour {
	
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	private float direction;
	
	// Update is called once per frame
	void Update () 
	{
		if (target)
		{

			Vector3 point = camera.WorldToViewportPoint(target.position);

			Vector3 delta = target.position - camera.ViewportToWorldPoint(
				new Vector3(0.5f, 0.25f, point.z)
				//new Vector3(0.5f, point.y, point.z)
			); //();


			//Debug.Log (delta);
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
		
	}
}