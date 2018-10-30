using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public TextMeshProUGUI currentScoreText;

    int currentScore = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore(int score)
    {
        currentScore += score;
        currentScoreText.text = currentScore.ToString();

        if(currentScore % 2 == 0){

        }
    }
}
