using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public Transform Target;

    GameManager gameManager;

	public float jumpForce;

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


    public void Jump()
	{
		currentState = PlayerState.Jumping;
		rb.AddForce(transform.position * jumpForce);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
        if(other.gameObject.name == "CoinL1"){
            Debug.Log("+1");
            gameManager.AddScore();
            Destroy(other.gameObject);
            //GameObject.Find("Obstacles").GetComponent<Obstacle>().speed = 100.0f;
            SceneManager.LoadScene("Level2");
            
        }

        if(other.gameObject.name == "CoinL2"){
            Debug.Log("+1");
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level3");
            
        }

        if (other.gameObject.name == "CoinL3")
        {
            Debug.Log("+1");
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level4");
            
        }

        if (other.gameObject.name == "CoinL4")
        {
            Debug.Log("+1");
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level1");
            
        }

    }

    // void OnTriggerEnter2D(Collider2D other){
    //     if (other.gameObject.tag == "Coin"){
    //         Debug.Log("+1");
    //         gameManager.AddScore();
    //          Destroy(other.gameObject);
    //         //GameObject.Find("Obstacles").GetComponent<Obstacle>().speed = 100.0f;
    //         SceneManager.LoadScene("Level2");
    //     }
    // }



}
