using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    private IEnumerator coroutine;
    public Text Score;
	// Use this for initialization
	void Start () {

        coroutine = IncreaseScoreValue(0.5f);
        StartCoroutine(coroutine);
	}
	
	// Update is called once per frame
	void Update () {
        string scoreValue = "";
        scoreValue += GameController.instance.score.ToString("0");

        Score.text = scoreValue;

        // Deal damage to player overtime
        IncreaseScoreValue(1);
	}

    private IEnumerator IncreaseScoreValue(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            GameController.instance.score += 1;
        }

    }
}
