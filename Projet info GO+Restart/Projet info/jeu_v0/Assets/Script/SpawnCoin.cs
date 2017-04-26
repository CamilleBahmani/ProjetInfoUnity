using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour {

	public Transform[] SpawnPoint;
	public float SpawnTime=1.5f;
	public GameObject Coin;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnCoins",SpawnTime,SpawnTime);
	}

	// Update is called once per frame
	void Update () {

	}

	public void SpawnCoins()
	{
		int spawnIndex = Random.Range (0, SpawnPoint.Length);
		Instantiate (Coin, SpawnPoint [spawnIndex].position,SpawnPoint [spawnIndex].rotation);
	}
}
