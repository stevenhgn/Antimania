using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public static GameController instance;

    public GameObject RainDrop;
    public int score { get; set; }
    bool gameOver = false;
        
    private void Awake()
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
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {

        if (PlayerController.instance.dead && !gameOver)
        {
            Debug.Log("Game over!");
            gameOver = true;
        }

        if(score%5 == 0)
        {
            Debug.Log("Spawn rain!");
        }
    }


}
