using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arriving : MonoBehaviour 
{
	//private Vector3 currentLocation;
	private Rigidbody Rb;
	private Vector3 currentVelocity;
	private Vector3 desiredVelocity;
	private Vector3 steeringForce;
	private Vector3 acceleration;

	private float maxSpeed;
	public float maxForce;

	public GameObject target;

	void Start ()
	{
		Rb = GetComponent<Rigidbody> ();
	}


	void FixedUpdate ()
	{
		//	Maximum speed is proportional to the target distance
		print (desiredVelocity.magnitude / 2);
		maxSpeed = desiredVelocity.magnitude / 2;

		//	Desired velocity = Target location - Current location
		desiredVelocity = target.transform.position - transform.position;
		//	Get Current velocity from RigidBody and scale according to remaining distance from target 
		currentVelocity = Rb.velocity;
		//	Steering force = Desired velocity - Current velocity
		steeringForce = (desiredVelocity.normalized * maxSpeed) - currentVelocity;
		//	Apply force
		Rb.AddForce (steeringForce * maxForce);
	}
}
