using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void PlayAgain()
    {

    }

   

    public void StartGame()
    {
        SceneManager.LoadScene("game");
        Debug.Log("Start Game");
    }

    public void QuitGamee()
    {
        Application.Quit();
        Debug.Log("Quit Game");

       // UnityEditor.EditorApplication.isPlaying = false;
    }

 
}
