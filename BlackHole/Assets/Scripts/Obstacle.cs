﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public float speed = -100.0f;
    public int numObjects;
    public GameObject prefab;
    void Start () {
        SpawnObj();
	}
	
	void Update () {
        MoveObstacles();
	}

    void MoveObstacles(){
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }

    void SpawnObj()
    {
        Vector2 center = transform.position;
        for (int i = 0; i < numObjects; i++)
        {
            Vector2 pos = obstacle(center, 1.9f);
            Quaternion rot = Quaternion.FromToRotation(Vector2.up, center - pos);
            Instantiate(prefab, pos, rot);
        }
    }

    Vector2 obstacle(Vector2 center, float radius)
    {
        float ang = Random.value * 360;
        Vector2 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return pos;
    }

}

