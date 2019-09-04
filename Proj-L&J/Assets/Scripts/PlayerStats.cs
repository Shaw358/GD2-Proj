using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int playerHP;

    // Start is called before the first frame update
    void Start()
    {
        playerHP = 3;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BulletEnemy")
        {
            playerHP -= 1;
        }
    }
}
