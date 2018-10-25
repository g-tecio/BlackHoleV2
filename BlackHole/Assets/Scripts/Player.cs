using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Transform Target;
	private Vector3 zAxis = new Vector3(0,0,1);

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
        if(other.gameObject.tag == "Coin"){
            Destroy(other.gameObject);

        }
	}



}
