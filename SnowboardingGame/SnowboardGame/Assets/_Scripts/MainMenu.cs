using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Scene management so we can switch scenes

public class MainMenu : MonoBehaviour {

    public void PlayGame() //Loads the game
    {
        SceneManager.LoadScene(1); //Load the next scene in the build
    }

    public void QuitGame() //Quit Game function
    {
        Application.Quit(); //Application will quit (Only works when built)
    }
}
