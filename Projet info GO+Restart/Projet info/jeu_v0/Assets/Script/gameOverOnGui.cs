using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverOnGui : MonoBehaviour {

	static public Text gameOverGuiText;
	static int bestScore;
	// Use this for initialization
	void Start () 
	{
		bestScore = 0;
		gameOverGuiText = GetComponent<Text>();
	}

	public static void setGameOver(int score)
	{
		if (score > bestScore) 
		{
			bestScore = score;
		}
		gameOverGuiText.text = "Game Over !\n" + 
							   "Your Score : " + score + ", Best Score : " + bestScore +
							   "\n Press 'R' to Restart";
	}

	public static void reset()
	{
		gameOverGuiText.text = "";
	}
}
