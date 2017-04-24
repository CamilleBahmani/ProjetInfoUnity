using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeOnGui : MonoBehaviour {

	static public Text timeGuiText;
	// Use this for initialization
	void Start () 
	{
		timeGuiText = GetComponent<Text>();
	}

	public static void setTimeOnGui(int minutes, int secondes)
	{
		timeGuiText.text = "Remaining Time : " + minutes +" : "+ secondes;
	}
}
