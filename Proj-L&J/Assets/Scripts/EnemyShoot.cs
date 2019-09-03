using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    private Transform BFirePoint1;
    private Transform BFirePoint2;
    private Transform BFirePoint3;
    private Transform BFirePoint4;
    private bool canShoot;

    [SerializeField] private GameObject EnemyBullet;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
        BFirePoint1 = GameObject.Find("BFirePoint1").transform;
        BFirePoint2 = GameObject.Find("BFirePoint2").transform;
        BFirePoint2 = GameObject.Find("BFirePoint3").transform;
        BFirePoint2 = GameObject.Find("BFirePoint4").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && canShoot == true)
        {
            StartCoroutine(ShootBullet());
        }

        for (int i = 0; i < 13; i++)
        {
            StartCoroutine(ShootBullet());
            StartCoroutine(Boy());

        }
    }

    private IEnumerator Boy()
    {
        yield return new WaitForSecondsRealtime(1);
    }



    private IEnumerator ShootBullet()
    {
        canShoot = false;
        Instantiate(EnemyBullet, BFirePoint1.position, BFirePoint1.rotation);
        Instantiate(EnemyBullet, BFirePoint2.position, BFirePoint2.rotation);
        Instantiate(EnemyBullet, BFirePoint3.position, BFirePoint3.rotation);
        Instantiate(EnemyBullet, BFirePoint4.position, BFirePoint4.rotation);
        yield return new WaitForSeconds(1.1F);
        canShoot = true;
    }
}
