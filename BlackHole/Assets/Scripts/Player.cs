using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float jumpForce;

    bool coinUp = false;

    Rigidbody2D rb;



	enum PlayerState{
		Standing, Jumping, Falling
	}

	PlayerState currentState = PlayerState.Falling;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
	
	}

    void AddScore(){
        GameObject.Find("GameManager").GetComponent<ScoreManager>().addScore(1);
    }

    void AddNextCoin(){
        GameObject.Find("Coins").GetComponent<SpawnCoin>().SpawnObj();
    }

    void AddNextObs(){
        GameObject.Find("Obstacles").GetComponent<Spawn>().SpawnObj();
    }

    void AddHole(){
        GameObject.Find("HolePosition").GetComponent<SpawnHole>().SpawnHoleAround();
    }

    public void Jump()
	{
		currentState = PlayerState.Jumping;
		rb.AddForce(transform.position * jumpForce);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
        if(other.gameObject.tag == "Coin"){
            AddScore();
            Destroy(other.gameObject);
            if (coinUp == false){
                coinUp = true;
                GameObject.Find("Coins").GetComponent<CoinMovement>().speed = -75.0f;
                GameObject.Find("Obstacles").GetComponent<Obstacle>().speed = -50.0f;
                AddNextCoin();
                AddNextObs();
            } else {
                coinUp = false;
                GameObject.Find("Coins").GetComponent<CoinMovement>().speed = 75.0f;
                GameObject.Find("Obstacles").GetComponent<Obstacle>().speed = -50.0f;
                AddNextCoin();
                AddNextObs();
                if (GameObject.Find("HolePosition").GetComponent<ScoreManager>().currentScore == 2)
                {
                    AddHole();
                }
            }
        }

        if(other.gameObject.tag == "HoleDoor"){
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level2");
        }

        //if(other.gameObject.name == "CoinL2"){

        //    Destroy(other.gameObject);
        //    SceneManager.LoadScene("Level3");

        //}

        //if (other.gameObject.name == "CoinL3")
        //{
        //    Destroy(other.gameObject);
        //    SceneManager.LoadScene("Level4");

        //}

        //if (other.gameObject.name == "CoinL4")
        //{
        //    Destroy(other.gameObject);
        //    SceneManager.LoadScene("Level5");

        //}

        //if (other.gameObject.name == "CoinL5")
        //{
        //    Destroy(other.gameObject);
        //    SceneManager.LoadScene("Level6");

        //}

        //if (other.gameObject.name == "CoinL6")
        //{
        //    Destroy(other.gameObject);
        //    SceneManager.LoadScene("Level7");

        //}

        //if (other.gameObject.name == "CoinL7")
        //{
        //    Destroy(other.gameObject);
        //    SceneManager.LoadScene("Level1");

        //}

    }

}
