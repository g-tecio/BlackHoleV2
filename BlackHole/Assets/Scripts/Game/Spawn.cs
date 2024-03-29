﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public int numObjects;
    public GameObject obj1;


    // Use this for initialization
    void Start()
    {
        SpawnObj();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnObj()
    {
        Vector2 center = transform.position;
        for (int i = 0; i < numObjects; i++)
        {
            Vector2 pos = obstacle(center, 1.9f);
            Quaternion rot = Quaternion.FromToRotation(Vector2.up, center - pos);
            GameObject childObject = Instantiate(obj1, pos, rot); //as GameObject;
            childObject.transform.parent = transform;
        }
    }

    Vector2 obstacle(Vector2 center, float radius)
    {

        float ang = Random.value * 270 / 4;
        Vector2 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return pos;
    }
}
