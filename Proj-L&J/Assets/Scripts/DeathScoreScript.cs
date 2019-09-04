using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeathScoreScript : MonoBehaviour
{
    private TextMeshPro Stats;
    private int PlayerScore;
    private float SurvivalTime;
    // Start is called before the first frame update
    void Start()
    {
        Stats = GetComponent<TextMeshPro>();
        PlayerScore = GameObject.Find("Gamemanager").GetComponent<GameManager>().score;
        SurvivalTime = GameObject.Find("Gamemanager").GetComponent<GameManager>().timer;
    }

    private IEnumerator TextScore()
    {
        yield return new WaitForSeconds(0.5f);
        Stats.text = "Score: " + PlayerScore;
        yield return new WaitForSeconds(0.5f);
        Stats.text = "Score: " + PlayerScore + "\n\nSurvival Time: " + SurvivalTime;
        yield return new WaitForSeconds(0.5f);
        Stats.text = "Score: " + PlayerScore + "\n\nSurvival Time: " + SurvivalTime + "\n\n\n\n\nBetter Luck next time Ace...";
        yield return new WaitForSeconds(0.5f);
        Stats.text = "Score: " + PlayerScore + "\n\nSurvival Time: " + SurvivalTime + "\n\n\n\n\nBetter Luck next time Ace..." + "\n\nStatus: MISSION FAILED";
    }

}
