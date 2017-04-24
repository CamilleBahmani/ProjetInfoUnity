using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAleatoire : MonoBehaviour 
{
	public float parametreDeRotation;

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * parametreDeRotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
