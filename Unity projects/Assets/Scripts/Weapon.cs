using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public float fireRate = 0f;
	public float damage = 10f;
	public LayerMask notToHit;

	private float timeToFire = 0f;
	public Transform firePoint;

	// Use this for initialization
	void Awake () {
		firePoint = transform.FindChild("FirePoint");
		if (firePoint == null)
		{
			Debug.LogError("No fire point");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (fireRate == 0)
		{
			if (Input.GetMouseButtonDown(0))
		    {
				Shoot();
			}
		}
		else
		{
			if (Input.GetMouseButton(0) && Time.time > timeToFire)
			{
				timeToFire = Time.time + 1 / fireRate;	
				Shoot();
			}
		}
	}

	void Shoot()
	{
		Debug.Log("TEST");
		//tells where the mouse position is relative to the world, 
		//not relative to the screen
		Vector2 mousePosition = new Vector2(
			Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 
			Camera.main.ScreenToWorldPoint(Input.mousePosition).y
		);
		Vector2 firePointPosition = new Vector2(
			firePoint.position.x, 
			firePoint.position.y
		);
	}
}


//https://youtu.be/KKgtC_Gy65c?t=5m29s