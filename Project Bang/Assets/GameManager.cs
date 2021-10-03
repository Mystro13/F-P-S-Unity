using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    void Start()
    {
        if (instance == null)

        {
            instance = this;
        }

        if (instance != this)
            Destroy(gameObject);


        DontDestroyOnLoad(gameObject);
    }



    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {

    }
   
}

