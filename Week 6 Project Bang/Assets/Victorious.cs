using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victorious : MonoBehaviour
{
  public void PlayAgain()
    {
        GameManager.instance.StartGame();
    }

    public void CallMainMenu()
    {
        GameManager.instance.CallMainMenu();
    }
}
