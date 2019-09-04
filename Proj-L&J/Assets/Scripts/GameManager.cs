using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    //Scene currentScene = SceneManager.GetActiveScene();
    public bool Player2 = false;
    public int score;
    public float timer;



    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
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
    }

    void Update()
    {
        score = GameObject.Find("ScoreText").GetComponent<ScoreScript>().score;
        Debug.Log(score);
        timer = GameObject.Find("ScoreText").GetComponent<ScoreScript>().timer;
    }
}
