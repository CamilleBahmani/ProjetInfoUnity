using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MenuPause : MonoBehaviour
{
	private bool isPaused = false; //Permet de savoir si le jeu est en pause ou pas
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			isPaused =true;
		}	

		if (isPaused)
		{
			Time.timeScale = 0f; //Le temps s'arrete
		}
		else
		{
			Time.timeScale = 1.0f; //Le temps reprend
		}
	}

	void OnGUI()
	{
		if (isPaused) {
			//Si le bouton est pressé alors isPaused devient faux  donc le jeu reprend
			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 20, 80, 40), "Continuer")) {
				isPaused = false;
			}

			//Si le bouton est pressé on charge la page du menu principal

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 40, 80, 40), "Quitter")) {
				Application.LoadLevel ("menu");
			}
		}
	}

}
