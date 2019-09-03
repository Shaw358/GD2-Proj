using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAi : MonoBehaviour
{
    private int bossHP;
    private int timesHit;
    [SerializeField] private Texture HpTexture;
    // Start is called before the first frame update
    void Start()
    {
        bossHP = 20;
    }

    // Update is called once per frame
    void Update()
    {
        if(timesHit == 25)
        {
            timesHit = 0;
            bossHP -= 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "PlayerBullet")
        {
            timesHit += 1;
        }
    }

    private void OnGUI()
    {
        for (int i = 0; i <= bossHP; i++)
        {
            GUI.DrawTexture(new Rect(70, 50, 50 * i, 20), HpTexture, ScaleMode.ScaleToFit, false, 1.0F);
        }
    }
}
