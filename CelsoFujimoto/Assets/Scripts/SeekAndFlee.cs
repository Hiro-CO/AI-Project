using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekAndFlee : MonoBehaviour
{
	//	Seek or Flee
	public bool seekingOrFleeing = true;

	//private Vector3 currentLocation;
	private Rigidbody Rb;
	private Vector3 currentVelocity;
	private Vector3 desiredVelocity;
	private Vector3 steeringForce;
	private Vector3 acceleration;

	public float maxVelocity;
	public float mass;

	public GameObject target;

	void Start ()
	{
		Rb = GetComponent<Rigidbody> ();
	}


	void Update ()
	{
		if (seekingOrFleeing)
		{			//	Seeking
			//	Desired velocity = Target location - Current location
			desiredVelocity = target.transform.position - transform.position;
		} else {	//	Fleeing
			//	Desired velocity = Current location - Target location
			desiredVelocity = transform.position - target.transform.position;
		}

		//	Get Current velocity from RigidBody
		currentVelocity = Rb.velocity;
		//	Normalize and multiply Desired Velocity
		desiredVelocity = desiredVelocity.normalized * maxVelocity;
		//	Steering force = Desired velocity - Current velocity
		steeringForce = desiredVelocity - currentVelocity;
		//	Apply force
		Rb.AddForce (steeringForce / mass);
	}
}
