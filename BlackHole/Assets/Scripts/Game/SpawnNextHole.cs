using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNextHole : MonoBehaviour {

    public float spawnRate = 1f;

    public GameObject prefab;

    private float nextTimeToSpawn = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //SpawnHole();
    }

    public void SpawnHole(){
        if (Time.time >= nextTimeToSpawn)
        {
            GameObject childObject = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            childObject.transform.parent = transform;
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
    }
}
