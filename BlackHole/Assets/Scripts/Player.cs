using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public Transform Target;
	private Vector3 zAxis = new Vector3(0,0,1);

	private float RotateSpeed= 0.0f;

	public float jumpForce;

	 Rigidbody2D rb;


	enum PlayerState{
		Standing, Jumping, Falling
	}

	PlayerState currentState = PlayerState.Falling;


	


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	
	// Update is called once per frame
	

	void Update()
	{
		GetInput();
		this.transform.RotateAround(Target.position, zAxis, RotateSpeed);
	}

	void GetInput()
	{
		if (Input.GetMouseButton(0))
		{
			if (currentState == PlayerState.Standing)
			{
				Jump();
			}
		}
	}

    public void Jump()
	{
		currentState = PlayerState.Jumping;
		rb.AddForce(transform.position * jumpForce);
	}
	

	

	void OnCollisionEnter2D(Collision2D other)
	{
		
		currentState = PlayerState.Standing;
	}



}
