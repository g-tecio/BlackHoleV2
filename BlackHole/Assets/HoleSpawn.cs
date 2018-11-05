using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSpawn : MonoBehaviour {

	public float shrinkSpeed = 3f;
	// Use this for initialization
	void Start () {
		//transform.localScale = Vector3.one * 10f;
	}
	
	// Update is called once per frame
	void Update () {
	
			
		
	}

	public void Shrink(){
	transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

	if (transform.localScale.x <= .05f){
		Destroy(gameObject);
	}
}
}

