using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet1Enemy : MonoBehaviour
{
    [SerializeField] private int speed = 10;
  
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall" || collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
