using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public float speed = -100.0f;
    
    void Start () {
       
	}
	
	void Update () {
        MoveObstacles();
	}

    void MoveObstacles(){
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

    

}

