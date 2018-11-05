using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject gameOverPanel;

    void Awake()
    {
        Time.timeScale = 1.0f;
    }

    public void GameOver(){
        StartCoroutine(gameOverCoroutine());
    }

    IEnumerator gameOverCoroutine(){
        Time.timeScale = 0.1f;
        yield return new WaitForSecondsRealtime(1f);
        gameOverPanel.SetActive(true);

        yield break;
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
