using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    
    public Text Score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        string scoreValue = "";
        scoreValue += GameController.instance.score.ToString("0");

        Score.text = scoreValue;

        // Deal damage to player overtime
        IncreaseScoreValue(0.05f);
	}

    public void IncreaseScoreValue(float value)
    {
        GameController.instance.score += value;

    }
}
