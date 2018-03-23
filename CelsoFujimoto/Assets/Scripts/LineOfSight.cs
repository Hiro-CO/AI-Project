using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour
{
	public GameObject target;
	public float speed;

	private Vector3 direction;

	void Update ()
	{
		/*
			Vector3 Direction = target.transform - Cube.transform;
			// Direction.magnitude is the Distance between the Cube and target

			Direction.normalized * speed;
		 */

		direction = target.transform.position - transform.position;
		print (direction);

		if (Mathf.Abs (direction.x) > 1 || Mathf.Abs (direction.y) > 1)
			transform.position += direction.normalized * speed;
	}
}
