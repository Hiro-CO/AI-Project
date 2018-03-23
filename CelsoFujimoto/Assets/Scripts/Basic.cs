using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic : MonoBehaviour
{
	public GameObject target;
	public float speed;

	void Update ()
	{
		/*
		if (Cube.x > target.x) { Cube.x = Cube.x - 1 }
		if (Cube.x < target.x) { Cube.x = Cube.x + 1 }

		if (Cube.y > target.y) { Cube.y = Cube.y - 1 }
		if (Cube.y < target.y) { Cube.y = Cube.y + 1 }
		*/

		if (transform.position.x > target.transform.position.x)
			transform.Translate ( Vector3.left * Time.deltaTime * speed );
		if (transform.position.x < target.transform.position.x)
			transform.Translate ( Vector3.right * Time.deltaTime * speed );

		if (transform.position.y > target.transform.position.y)
			transform.Translate ( Vector3.down * Time.deltaTime * speed );
		if (transform.position.y < target.transform.position.y)
			transform.Translate ( Vector3.up * Time.deltaTime * speed );
	}

}
