using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    private TextMeshPro TextScore;
    public int score;
    private int playerHP;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        TextScore = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        playerHP = GameObject.Find("Player").GetComponent<PlayerStats>().playerHP;
        score++;
        TextScore.text = "Score: " + score.ToString() + "\n\nPlayer HP: " + playerHP;

    }
}
