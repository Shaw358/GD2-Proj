using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public int playerHP;
    [SerializeField] private GameObject DeathAnim;
    [SerializeField] private Transform ThisGameObject;
    [SerializeField] private bool CanTakeDamage;

    // Start is called before the first frame update
    void Start()
    {
        CanTakeDamage = true;
        playerHP = 10;

    }

    private void Update()
    {
        if (playerHP <= 0)
        {
            SceneManager.LoadScene("PlayerSelectScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyBullet" && CanTakeDamage == true)
        {
            Debug.Log("aids");
            CanTakeDamage = false;
            playerHP -= 1;
            StartCoroutine(CanTakeDam());
        }
    }

    private IEnumerator CanTakeDam()
    {
        yield return new WaitForSeconds(5);
        CanTakeDamage = true;
    }
}
