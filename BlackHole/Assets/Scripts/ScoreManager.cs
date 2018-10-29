using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

	public TextMeshProUGUI currentScoreText;
	int currentScore = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int score){
		currentScore += score;
		currentScoreText.text = currentScore.ToString();
	}
}
