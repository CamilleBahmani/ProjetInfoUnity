using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreOnGui : MonoBehaviour {

	static public Text scoreGuiText;
	// Use this for initialization
	void Start () 
	{
		scoreGuiText = GetComponent<Text>();
	}

	public static void setScoreOnGui(int score)
	{
		scoreGuiText.text = "Score : " + score;
	}
}
