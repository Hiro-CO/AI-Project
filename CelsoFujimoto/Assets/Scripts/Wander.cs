using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
	public GameObject carrot;
	public float maxSpeed;
	//public float rotSpeed;
	private Vector3 desiredVelocity;
	private Vector3 steering;
	private Rigidbody Rb;

	private float t = 1.0f;	// Lerp (T)ime
	private float rngX;
	private float rotZ;
	[HideInInspector]
	public float turn;

	//private float time;
	private float timer = 0.5f;
	private float lastEvent;

	void Start ()
	{
		Rb = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		float smoothRandom = Mathf.Lerp (carrot.transform.localPosition.x, rngX, t);
		carrot.transform.localPosition = new Vector3 (	smoothRandom,
														carrot.transform.localPosition.y,
														0f);

		t += 0.5f * Time.deltaTime;
		if (t > 1.0f)
		{
			t = 0.0f;
			rngX = Random.Range (-2.0f, 2.0f);
		}
	

		/*
		float rotZ = Mathf.Atan2(desiredVelocity.y, desiredVelocity.x) * Mathf.Rad2Deg;
		float smoothZ = Mathf.LerpAngle (transform.rotation.z, rotZ, t);
		float rotZ = 0f;
		rotZ = rotZ + rngX;*/
		rotZ += smoothRandom;
		transform.rotation = Quaternion.Euler (0f, 0f, rotZ + turn);

		//transform.LookAt (desiredVelocity.normalized, Vector3.forward);

		/*
		float step = rotSpeed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards (transform.forward, desiredVelocity, step, 0.0f);
		transform.rotation = Quaternion.LookRotation (newDir);
		*/

		desiredVelocity = carrot.transform.position - transform.position;
		//Rb.AddForce (desiredVelocity.normalized * maxSpeed);
		Rb.velocity = desiredVelocity.normalized * maxSpeed;
	}

}
