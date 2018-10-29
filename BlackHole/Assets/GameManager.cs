using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

	public TextMeshProUGUI currentScoreText;
	int currentScore;
	// Use this for initialization
	void Start () {
		currentScore = 0;
		SetScore();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore()
	{
		currentScore++;
		SetScore();
	}

	void SetScore(){
		currentScoreText.text = currentScore.ToString();
	}
}
