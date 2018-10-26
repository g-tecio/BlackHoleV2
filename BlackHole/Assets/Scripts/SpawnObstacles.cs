using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour {

	public int numObjects;
    public GameObject prefab;

	// Use this for initialization
	void Start () {
		Spawn();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Spawn(){
        	Vector2 center = transform.position;
        for (int i = 0; i < numObjects; i++){
            Vector2 pos = obstacle(center, 1.9f);
            Quaternion rot = Quaternion.FromToRotation(Vector2.up, center-pos);
            Instantiate(prefab, pos, rot);
            

        }
        
    }
    Vector2 obstacle (Vector2 center, float radius){
        float ang = Random.value * 360;
        Vector2 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return pos;
        
    }
}
