using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDetection : MonoBehaviour
{
	void OnTriggerEnter (Collider other)
	{
		//transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y * -1f, 0f);
		Wander wander = transform.parent.GetComponent<Wander> ();
		wander.turn += 180f;
	}
}
