using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour {

    public float speed = -75f;
    public float radiusM = 1.45f;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        MoveCoin();
	}

    void MoveCoin()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
