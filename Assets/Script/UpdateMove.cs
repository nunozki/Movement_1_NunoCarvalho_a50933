﻿using UnityEngine;

public class UpdateMove : MonoBehaviour
{
	public float speed = 0.5f;
	void Update()
	{
		this.transform.Translate(0, 0, Time.deltaTime * speed);
	}
}
