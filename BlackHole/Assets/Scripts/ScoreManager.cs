using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public TextMeshProUGUI currentScoreText;
    public Image UIImagen;
    public Image UIButton;
    //public Image UICircle;
    int currentScore = 0;

    // Use this for initialization
    void Start()
    {
        UIImagen = GameObject.Find("ImageChange").GetComponent<Image>();
        UIButton = GameObject.Find("Button").GetComponent<Image>();
        //UICircle = GameObject.Find("Hole").GetComponent<Image>();
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
            UIButton.sprite = Resources.Load<Sprite>("Assets/Level2/BtnN2");
            //UICircle.sprite = Resources.Load<Sprite>("Assets/Level2/Nl2");
        } else if (currentScore == 4){
            UIImagen.sprite = Resources.Load<Sprite>("Assets/Level3/Wallpaper3");
            UIButton.sprite = Resources.Load<Sprite>("Assets/Level3/BtnN3");
        }
    }
}
