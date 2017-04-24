using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static int pointScore;

	private static float targetTime;
	private static float actualTime;
	public float gameTime = 30;

	private static bool gameOver;


	// Use this for initialization
	void Start () 
	{
		gameOver = false;

		// Ici on fait demarrer notre compteur de temps
		actualTime = gameTime;
		targetTime = Time.time + gameTime;

		// Ici on fait demarrer notre compteur de points
		pointScore = 0;

		// Ici on met à jour l'affichage du score et du temps sur la GUI
		TimeOnGui.setTimeOnGui ((int) (actualTime / 60) , (int) (actualTime % 60));
		ScoreOnGui.setScoreOnGui (pointScore);
	}

	void Update () 
	{
		if (!gameOver) 
		{
			actualTime = targetTime - Time.time;
			TimeOnGui.setTimeOnGui ((int)(actualTime / 60), (int)(actualTime % 60));

			if (actualTime <= 0) //si le temps est égal à zéro, partie finie
			{
				GameOver ();
			}
		} else 
		{
			// redemarrer le jeu
			if (Input.GetKeyDown (KeyCode.R)) 
			{
				gameOver = false;
				gameOverOnGui.reset ();
				pointScore = 0;
				ScoreOnGui.setScoreOnGui (0);
				actualTime = gameTime;
				targetTime = Time.time + gameTime;
				TimeOnGui.setTimeOnGui ((int) (actualTime / 60) , (int) (actualTime % 60));
				mouvement.enableMouvement (true);
				mouvement.reset ();
			}
		}


	}

	public static void ChangeTime(int timeOffset)//permet de modifier le temps lorsqu'une horloge est ramassée
	{
		if (!gameOver) 
		{
			targetTime += timeOffset;
		}
	}

	public static void AddScore(int scoreToAdd)//permet d'augmenter le score à chaque pièce ramassée
	{
		if (!gameOver) 
		{
			pointScore++;
			ScoreOnGui.setScoreOnGui (pointScore);
		}
	}

	public static void GameOver()
	{
		//pas très beau mais fonctionne...
		gameOverOnGui.setGameOver(pointScore);
		gameOver = true;
		mouvement.enableMouvement (false);

	}
}
