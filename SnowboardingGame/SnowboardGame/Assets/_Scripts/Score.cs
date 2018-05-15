using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
    int score;
    int highScore;
    public Text scoreText;
    public Text highScoreTect;
    GameObject scoreobject;
    bool gameIsPlaying = false;
   

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (gameIsPlaying == true)
        {
            setScoreText();
        }
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
        PlayerPrefs.SetInt("Score", score);
    }

    public void saveScores() 
    {
        PlayerPrefs.SetInt("Score", score);
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore"));
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
        }
        PlayerPrefs.SetInt("HighScore", 0);
    }

    public void loadScore()
    {
        gameIsPlaying = true;
        score = PlayerPrefs.GetInt("Score", score);
    }
}
