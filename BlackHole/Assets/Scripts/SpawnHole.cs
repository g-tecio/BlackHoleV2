using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHole : MonoBehaviour {

    public GameObject door;

    void Start()
    {
        //SpawnHoleAround();
    }

    void Update()
    {

    }

    public void SpawnHoleAround()
    {
        Vector2 center = transform.position;
        for (int i = 0; i < 1; i++)
        {
            Vector2 pos = obstacle(center, 1.45f);
            Quaternion rot = Quaternion.FromToRotation(Vector2.down, center - pos);
            GameObject childObject = Instantiate(door, pos, rot);
            childObject.transform.parent = transform;
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
