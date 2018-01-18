using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    public static PlayerController instance;
    int score;
    bool dead = false;

    void Awake()
    {
        // If we don't currently have a game controll....
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(this); // this object needs to be kept throughout the wholegame
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKey(KeyCode.RightArrow))){
            //transform.position = new Vector3(2, 0, 0);
            transform.Translate(Vector3.right * Time.deltaTime *2, Camera.main.transform);
        }
        if((Input.GetKey(KeyCode.LeftArrow))) {
            transform.Translate(Vector3.left * Time.deltaTime *2, Camera.main.transform);

        }
            
    
	}

    public bool IsDead() 
    {
        Debug.Log("You died.");
        dead = true;
        return dead;
    }

}
