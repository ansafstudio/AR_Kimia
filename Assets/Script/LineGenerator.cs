﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour {
	public GameObject ropePrefab;
	public Vector3 pointA;
	public Vector3 pointB;
	Vector3 instantiatePosition;
	float lerpValue;
	float distance;
	int segmentsToCreate;

	public void InstantiateSegments()
	{
		//Here we calculate how many segments will fit between the two points
		segmentsToCreate = Mathf.RoundToInt(Vector3.Distance(pointA, pointB) / 0.5f);
		//As we'll be using vector3.lerp we want a value between 0 and 1, and the distance value is the value we have to add
		distance = 1 / segmentsToCreate;
		for(int i = 0; i < segmentsToCreate; i++)
		{
			//We increase our lerpValue
			lerpValue += distance;
			//Get the position
			instantiatePosition = Vector3.Lerp(pointA, pointB, lerpValue);
			//Instantiate the object
			Instantiate(ropePrefab, instantiatePosition, transform.rotation);
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
