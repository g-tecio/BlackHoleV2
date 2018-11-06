using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour {

	
	public float shrinkSpeed = 3f;
	// Use this for initialization
    public void Start () {
		//transform.localScale = Vector3.one * 10f;
		enabled = false;
	}
	
	// Update is called once per frame
	public void Update () {
	
			ShrinkObstacles();
		
	}

	public void ShrinkObstacles(){
	transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

		if (transform.localScale.x <= .15f){
			Destroy(gameObject);
		}
	}
}
