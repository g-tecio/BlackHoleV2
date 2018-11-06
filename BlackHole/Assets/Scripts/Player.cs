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
	}

	void Update()
	{
	
	}


    void EffectTrigger()
    {
        GameObject.Find("Hole").GetComponent<HoleSpawn>().enabled = true;
    }

    void AddScore(){
        GameObject.Find("GameManager").GetComponent<ScoreManager>().addScore(1);
    }

 

    void AddNextObs(){
        GameObject.Find("Obstacles").GetComponent<Spawn>().SpawnObj();
    }

    public void Jump()
	{
		rb.AddForce(transform.position * jumpForce);
	}


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "HoleDoor")
        {
            AddScore();
            AddNextObs();
            EffectTrigger();
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
