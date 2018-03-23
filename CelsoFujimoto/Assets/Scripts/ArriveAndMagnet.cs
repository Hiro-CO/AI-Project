using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArriveAndMagnet : MonoBehaviour
{
	public bool arriveOrMagnet;

	public GameObject target;
	public float radius;
	public float maxSpeed;
	private Vector3 desiredVelocity;
	private Rigidbody Rb;

	private float arrive;
	private float magnet;

	void Start ()
	{
		Rb = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		desiredVelocity = target.transform.position - transform.position;
		if (arriveOrMagnet)
		{
			Rb.velocity = desiredVelocity.normalized * arrive * maxSpeed;
		} else {
			Rb.velocity = desiredVelocity.normalized * magnet * maxSpeed;
		}

		if (desiredVelocity.magnitude > radius)
		{
			arrive = 1F;
			magnet = 0.1f;
		} else {
			arrive = desiredVelocity.magnitude / radius;
			magnet = 1f - (desiredVelocity.magnitude / radius);
		}
	}
}
