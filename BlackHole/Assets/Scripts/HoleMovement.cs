using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleMovement : MonoBehaviour {

    public float speed = -65f;
    public float radiusM = 1.45f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoveHole();
    }

    void MoveHole()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
