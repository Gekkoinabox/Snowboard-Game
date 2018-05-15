using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    int score;
    int highScore;
    public Text scoreText;
    public Text highScoreTect;
    string scoreString = "Score";
    string highScoreString = "HighScore";
    GameObject scoreobject;
   

    // Use this for initialization
    void Start () {
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        setScoreText();
	}

    public void AddScore(int amount)
    {
        score += amount;
    }

    void setScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void resetScore()
    {
        score = 0;
        PlayerPrefs.SetInt(scoreString, score);
    }

    public void saveScores() 
    {
        PlayerPrefs.SetInt(scoreString, score);
        if (score > highScore)
        {
            highScore = score;
        }
        PlayerPrefs.SetInt(highScoreString, highScore);
    }

    public void loadScore()
    {
        score = PlayerPrefs.GetInt(scoreString, score);
    }
}
