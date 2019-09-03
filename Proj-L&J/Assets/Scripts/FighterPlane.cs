using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterPlane : MonoBehaviour
{
    private int speed = 1;
    private bool moveForward;
    private bool moveBackward = false;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform Firepoint1;
    [SerializeField] private Transform Firepoint2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Ai());
        moveForward = true;
        moveBackward = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveForward == true)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if(moveBackward == true)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    private IEnumerator Ai()
    {
        yield return new WaitForSeconds(2);
        moveForward = false;
        for (int i = 0; i < 3; i++)
        {
            Instantiate(Bullet, Firepoint1.position, Firepoint1.rotation);
            yield return new WaitForSeconds(0.2f);
            Instantiate(Bullet, Firepoint2.position, Firepoint2.rotation);
            yield return new WaitForSeconds(0.2f);
        }
        moveBackward = true;
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    } 
}
