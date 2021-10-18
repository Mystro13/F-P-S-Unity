using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Image healthBar;

    [SerializeField]
    Image ammoBar;

    [SerializeField]
    private float health;

    [SerializeField]
    private float ammo;

    public static GameManager instance;

    GameOver GameOverScene;

  

    void Start()
    {
        if (instance == null)

        {
            instance = this;
        }

        if (instance != this)
            Destroy(gameObject);


        DontDestroyOnLoad(gameObject);

        health = 10.0f;
        ammo = 10f;
        healthBar.fillAmount = health / 10f;
        ammoBar.fillAmount = ammo / 10f;
        
        
    }

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }
    public void subtractHealth()
    {
        health -= 1;

        UpdateHUD();
    }

    public void addAmmo()
    {
        ammo += 5;

        UpdateHUD();
    }

    public void subtractAmmo()
    {
        ammo -= 1;

        UpdateHUD();
    }

    void UpdateHUD()
    {
        healthBar.fillAmount = health / 10.0f;
        ammoBar.fillAmount = ammo / 10f;

        if (health <= 0)
        {
            //  Destroy(gameObject);

            OnGameOver();
        }

        GameObject[] targets = GameObject.FindGameObjectsWithTag("target");

        if (targets.Length == 0)
        {

            endGame();
        }
    }
    public bool HasAmmo()
    {
        return ammo > 0f;
    }

    public void OnGameOver()
    {

        SceneManager.LoadScene("game over");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("game");
    }

    public void CallMainMenu()
    {

        SceneManager.LoadScene("main menu");

    }
    public void endGame()
    {
        SceneManager.LoadScene("victory");
    }
    public void checkTargets()
    {
        UpdateHUD();
    }
  

}

