using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mouvement : MonoBehaviour
{

	static bool freeze;
	Vector3 initialLocation; 
	static bool positionReset;

	public float moveSpeed = 20f;
	public float turnSpeed = 50f;
	public float xMin, xMax, zMin, zMax;

	// Use this for initialization
	void Start()
	{ 
		initialLocation = transform.position;
		freeze = false;
		positionReset = false;
	}

	// Update is called once per frame
	void Update ()
	{
		if (positionReset) 
		{
			transform.position = initialLocation; 
			positionReset = false;
		}

		if (!freeze) 
		{
			//pour diriger le bateau
			if (Input.GetKey (KeyCode.UpArrow))
				transform.Translate (-Vector3.right * moveSpeed * Time.deltaTime);

			if (Input.GetKey (KeyCode.DownArrow))
				transform.Translate (Vector3.right * moveSpeed * Time.deltaTime);

			if (Input.GetKey (KeyCode.LeftArrow))
				transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);

			if (Input.GetKey (KeyCode.RightArrow))
				transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);


			// On utilise ce code pour éviter au bateau de sortir de la map
			GetComponent<Rigidbody> ().position = new Vector3 (
				Mathf.Clamp (GetComponent<Rigidbody> ().position.x, xMin, xMax),
				1.0f,
				Mathf.Clamp (GetComponent<Rigidbody> ().position.z, zMin, zMax)
			);
		}
	}

	public static void enableMouvement(bool mouvementEnabled)
	{
		freeze = !mouvementEnabled;
	}

	public static void reset()
	{
		positionReset = true;
	}

}