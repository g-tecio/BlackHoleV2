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

    public void Jump()
	{
		currentState = PlayerState.Jumping;
		rb.AddForce(transform.position * jumpForce);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
        if(other.gameObject.tag == "HoleDoor"){
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level2");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            AddScore();
            Destroy(collision.gameObject);
            if (coinUp == false)
            {
                coinUp = true;
                GameObject.Find("Coins").GetComponent<CoinMovement>().speed = -75.0f;
                GameObject.Find("Obstacles").GetComponent<Obstacle>().speed = -50.0f;
                AddNextCoin();
                AddNextObs();
            }
            else
            {
                coinUp = false;
                GameObject.Find("Coins").GetComponent<CoinMovement>().speed = 75.0f;
                GameObject.Find("Obstacles").GetComponent<Obstacle>().speed = -50.0f;
                AddNextCoin();
                AddNextObs();
            }
        }
    }

}
