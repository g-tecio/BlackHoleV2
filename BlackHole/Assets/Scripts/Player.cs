using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public Transform Target;

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
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level2");
            
        }

        if(other.gameObject.name == "CoinL2"){
        
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level3");
            
        }

        if (other.gameObject.name == "CoinL3")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level4");
            
        }

        if (other.gameObject.name == "CoinL4")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level5");
            
        }

        if (other.gameObject.name == "CoinL5")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level6");

        }

        if (other.gameObject.name == "CoinL6")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level7");

        }

        if (other.gameObject.name == "CoinL7")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level1");

        }

    }

}
