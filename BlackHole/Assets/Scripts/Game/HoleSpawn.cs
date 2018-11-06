using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSpawn : MonoBehaviour {

    Vector3 hole = new Vector3(3.86f, 3.86f, 0.0f);

	public float shrinkSpeed = 3f;
	// Use this for initialization
    public void Start () {
		//transform.localScale = Vector3.one * 10f;
		enabled = false;
	}
	
	// Update is called once per frame
	public void Update () {
	
			Shrink();
		
	}

	public void Shrink(){
        transform.localScale -= hole * shrinkSpeed * Time.deltaTime;

		if (transform.localScale.x <= .05f){
			Destroy(gameObject);
		}
	}
}

