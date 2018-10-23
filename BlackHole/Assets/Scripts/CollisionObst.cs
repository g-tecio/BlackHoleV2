using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionObst : MonoBehaviour {

    public GameObject DeathEffectObj;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject effectObj = Instantiate(DeathEffectObj, collision.contacts[0].point, Quaternion.identity);
            Destroy(effectObj, 1.5f);
            Destroy(collision.gameObject);
        }
    }
}
