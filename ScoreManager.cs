﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	
	public Text scoreText;
	public Text hiScoreText;

	public float scoreCount;
	public float hiScoreCount;

	public float pointsPerSecond;

	public bool scoreIncreasing;



	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{

		scoreCount += pointsPerSecond * Time.deltaTime;
		

		if (scoreCount > hiScoreCount) 
		{
			hiScoreCount = scoreCount;
		}

		scoreText.text = "Score: " + Mathf.Round (scoreCount);
		hiScoreText.text = "High Score: " + Mathf.Round (hiScoreCount);
	}
}
