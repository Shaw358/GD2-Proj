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

    public float timeBetweenEnemyBullet = 0.5f;
    public float timeBetweenWaves = 10f;
    private float countdown = 2f;

    private int waveIndex = 4;

    [SerializeField] private GameObject EnemyBullet;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
        BFirePoint1 = GameObject.Find("BFirePoint1").transform;
        BFirePoint2 = GameObject.Find("BFirePoint2").transform;
        BFirePoint3 = GameObject.Find("BFirePoint3").transform;
        BFirePoint4 = GameObject.Find("BFirePoint4").transform;

    }

    // Update is called once per frame
    void Update()
    {

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }

    void SpawnEnemy()
    {
        Instantiate(EnemyBullet, BFirePoint1.position, BFirePoint1.rotation);
        Instantiate(EnemyBullet, BFirePoint2.position, BFirePoint2.rotation);
        Instantiate(EnemyBullet, BFirePoint3.position, BFirePoint3.rotation);
        Instantiate(EnemyBullet, BFirePoint4.position, BFirePoint4.rotation);

    }

    IEnumerator SpawnWave()
    {
        if (timeBetweenWaves >= 3f)
        {
            timeBetweenWaves = timeBetweenWaves * 0.9f;
            timeBetweenEnemyBullet = timeBetweenEnemyBullet * 0.8f;
        }
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(timeBetweenEnemyBullet);
        }

    }
}








