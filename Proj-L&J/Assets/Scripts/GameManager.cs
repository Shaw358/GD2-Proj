using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //Scene currentScene = SceneManager.GetActiveScene();
    public bool Player2 = false;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        int[] highscore = new int[] {};
        //string sceneName = currentScene.name;

        //if (sceneName == "Battle")
        //{
        /*if(Player2 == false)
        {
            //Instantiate 1 player
        }
        if(Player2 == true)
        {
            //Instantiate 2 players
        }

        }*/
        Debug.Log(highscore);
    }

    void Update()
    {

    }
}
