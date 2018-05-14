using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Scene management so we can switch scenes

public class GameOverMenu : MonoBehaviour
{

    public void BackToMenu() //Loads the game
    {
        SceneManager.LoadScene(0); //Load the Main Menu
    }

    public void QuitGame() //Quit Game function
    {
        Application.Quit(); //Application will quit (Only works when built)
    }
}
