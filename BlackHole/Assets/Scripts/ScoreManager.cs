using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public TextMeshProUGUI currentScoreText;
    //public Image UIImagen;
    //public Image UIButton;
    //public Image UICircle;
    public int currentScore = 0;

    // Use this for initialization
    void Start()
    {
        //UIImagen = GameObject.Find("ImageChange").GetComponent<Image>();
        //UIButton = GameObject.Find("Button").GetComponent<Image>();
        //UICircle = GameObject.Find("Hole").GetComponent<Image>();
    }

    void AddHole()
    {
        GameObject.Find("HolePosition").GetComponent<SpawnHole>().SpawnHoleAround();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addScore(int score)
    {
        currentScore += score;
        currentScoreText.text = currentScore.ToString();

        if(currentScore == 2){
            AddHole();
        }
    }
}
