using UnityEngine;
using System.Collections;

public class OnCollision : MonoBehaviour {

	//public static int count;
	//public Text countText;
	//Collider other; 
	public GameObject explosion;
	public GameObject coinCollectedAnimation;

	void OnTriggerEnter(Collider other) //lorsque le bateau rentre en collision avec un objet, cette fonction est appelée
	{
		Vector3 animationPosition = new Vector3 (GetComponent<Transform> ().position.x, GetComponent<Transform> ().position.y + 5.0f, GetComponent<Transform> ().position.z);
		//Si l'objet est une pièce, alors on ajoute 1 au score
		if (other.gameObject.CompareTag("Object"))
		{
			Instantiate (coinCollectedAnimation, animationPosition, GetComponent<Transform> ().rotation);
			GameController.AddScore (1);
			other.gameObject.SetActive(false);
			Destroy (other.gameObject);
			//count = count + 1;
		}
		//Si l'objet est une bombe, alors le joueur a perdu
		if (other.gameObject.CompareTag("Mine"))
		{
			Instantiate (explosion,  animationPosition, GetComponent<Transform> ().rotation);
			GameController.GameOver ();
			other.gameObject.SetActive(false);
			Destroy (other.gameObject);
		}
		//Si l'objet est une horloge alors le joueur a une chance sur deux de gagner ou perdre 10 secondes
		if (other.gameObject.CompareTag ("Clock")) 
		{
			var randomInt = Random.Range(0,2);
			Instantiate (explosion,  animationPosition, GetComponent<Transform> ().rotation);
			if (randomInt == 1) {
				GameController.ChangeTime (10);
			} 
			else 
			{
				GameController.ChangeTime (-10);
			}
			other.gameObject.SetActive(false);
			Destroy (other.gameObject);
		}
	}

}
