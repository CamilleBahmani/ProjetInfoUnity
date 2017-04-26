using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeOnGui : MonoBehaviour {


	public static Text timeText;
	// Use this for initialization
	void Start () 
	{
		timeText = GetComponent<Text>();
	}

	public static void setTimeOnGui(int minutes, int secondes)
	{
		timeText.text = "Remaining Time : " + minutes +" : "+ secondes;
	}
}
