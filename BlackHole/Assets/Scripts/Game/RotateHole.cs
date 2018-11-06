using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHole : MonoBehaviour {

    public float speed = 50.0f;
	
	// Update is called once per frame
	void Update () {
        RotateHoleAround();
       
	}

    void RotateHoleAround(){
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
