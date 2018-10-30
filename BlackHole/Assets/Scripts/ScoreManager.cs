using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public TextMeshProUGUI currentScoreText;
    public Image UIImagen;
    int currentScore = 0;

    // Use this for initialization
    void Start()
    {
        UIImagen = GameObject.Find("ImageChange").GetComponent<Image>();
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
            UIImagen.sprite = Resources.Load<Sprite>("Assets/Level2/Wallpaper2");
        }
    }
}
