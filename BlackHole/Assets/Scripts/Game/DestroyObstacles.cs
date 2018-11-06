using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour {

    Vector3 obstacle = new Vector3(1.5f, 1.5f, 0.0f);
	public float shrinkSpeed = 0.1f;
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
        transform.localScale -= obstacle * shrinkSpeed * Time.deltaTime;

		if (transform.localScale.x <= .15f){
			Destroy(gameObject);
		}
	}
}
