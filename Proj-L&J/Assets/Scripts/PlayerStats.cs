using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int playerHP;
    private bool CanTakeDamage;

    // Start is called before the first frame update
    void Start()
    {
        CanTakeDamage = true;
        playerHP = 3;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BulletEnemy" && CanTakeDamage == true)
        {
            CanTakeDamage = false;
            playerHP -= 1;
        }
    }

    private IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(2);
        CanTakeDamage = true;
    }
}
