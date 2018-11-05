using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public float jumpForce;

    bool coinUp = false;

    Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
        AddHole();
	}

	void Update()
	{
	
	}

    void AddHole()
    {
        GameObject.Find("HolePosition").GetComponent<SpawnHole>().SpawnHoleAround();
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
		rb.AddForce(transform.position * jumpForce);
	}

	void OnCollisionEnter2D(Collision2D other)
	{

    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "HoleDoor")
        {
            Destroy(collision.gameObject);
            AddScore();
            AddHole();
            AddNextObs();
        }
        //if (collision.gameObject.tag == "Coin")
        //{
        //    AddScore();
        //    Destroy(collision.gameObject);
        //    if (coinUp == false)
        //    {
        //        coinUp = true;
        //        GameObject.Find("Coins").GetComponent<CoinMovement>().speed = -75.0f;
        //        GameObject.Find("Obstacles").GetComponent<Obstacle>().speed = -50.0f;
        //        AddNextCoin();
        //        AddNextObs();
        //    }
        //    else
        //    {
        //        coinUp = false;
        //        GameObject.Find("Coins").GetComponent<CoinMovement>().speed = 75.0f;
        //        GameObject.Find("Obstacles").GetComponent<Obstacle>().speed = -50.0f;
        //        AddNextCoin();
        //        AddNextObs();
        //    }
        //}
    }

}
