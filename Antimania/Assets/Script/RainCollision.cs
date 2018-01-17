using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Ground") 
        {
            Destroy(gameObject);
        }
        if (col.gameObject.name == "Ant_Player")
        {
            PlayerController.instance.Die();
                  
        }
    }
}
