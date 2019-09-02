using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalSceneManagerPSS : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject.Find("Player1Sprite").GetComponent<PlayerSprite1>().changeBool1();
            GameObject.Find("Player2Sprite").GetComponent<PlayerSprite2>().changeBool2();
        }
    }
}
