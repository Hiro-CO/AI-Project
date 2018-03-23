using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderThree : MonoBehaviour
{
	public GameObject carrot;

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

		rotZ += smoothRandom;
		transform.rotation = Quaternion.Euler (0f, 0f, rotZ + turn);
	}

}
