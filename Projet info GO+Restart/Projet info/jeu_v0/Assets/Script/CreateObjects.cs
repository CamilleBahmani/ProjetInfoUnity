using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour {

	public Transform[] SpawnPoint;
	public float SpawnTime=1.5f;
	public GameObject clock;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnClock",SpawnTime,SpawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnClock()
	{
		int spawnIndex = Random.Range (0, SpawnPoint.Length);
		Instantiate (clock, SpawnPoint [spawnIndex].position,SpawnPoint [spawnIndex].rotation);
	}
}
