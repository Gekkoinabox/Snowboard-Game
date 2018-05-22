using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
    int score; //Stores player score
    int highScore; //stores high score
    public Text scoreText; //get score text
    public Text highScoreText; //get high score text
    GameObject scoreobject; //set game object
    bool gameIsPlaying = false; //set if game playing
    public bool gameIsOver = false; //set game over to false
    public bool inMenu = false; //set in menu false

	// Update is called once per frame
	void Update () {
        if (inMenu == true)
        {
            resetScore();
        }
        if (gameIsPlaying == true)
        {
            setScoreText(); //Call function to refresh the score
        }
        if(gameIsOver == true)
        {
            showHighScore();
        }
	}

    public void AddScore(int amount) //set public so it can be accessed elsewhere
    {
        score += amount; //Add a set ammount to the score
    }
    

    void setScoreText() //set text object to be the players score
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void resetScore() //Function to reset the score
    {
        
        score = 0; //set the score back to 0
        PlayerPrefs.SetInt("Score", score); //set players current score in player prefs so it can be used outside of scenes
    }

    public void saveScores() //Function to save the score when the game is over but before the game scene changes
    {
        PlayerPrefs.SetInt("Score", score);
        if (score > highScore) //If the players score is greater than the highscore
        {
            PlayerPrefs.SetInt("HighScore", score); //set the highscore as the players score
        } 
        else
        {
            PlayerPrefs.SetInt("HighScore", highScore);
        } 
    }

    public void loadScore()
    {
        gameIsPlaying = true;
        score = PlayerPrefs.GetInt("Score", score);
        highScore = PlayerPrefs.GetInt("HighScore", highScore);
    }

    void showHighScore()
    {
        highScoreText.text = "HighScore: " + highScore; //Get High Score form player prefs and set the text to it
    }
}
