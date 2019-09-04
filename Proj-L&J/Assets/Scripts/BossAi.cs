using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAi : MonoBehaviour
{
    private int bossHP;
    private int timesHit;
    [SerializeField] private Texture HpTexture;

    [SerializeField] private GameObject fighter;
    [SerializeField] private GameObject solarLaser;

    [SerializeField] private Transform FirepointFigher1;
    [SerializeField] private Transform FirepointFigher2;

    [SerializeField] private Transform FirePointSolar1;
    [SerializeField] private Transform FirePointSolar2;
    [SerializeField] private Transform FirePointSolar3;
    [SerializeField] private Transform FirePointSolar4;
    [SerializeField] private Transform FirePointSolar5;
    [SerializeField] private Transform FirePointSolar6;
    [SerializeField] private Transform FirePointSolar7;
    [SerializeField] private Transform FirePointSolar8;
    [SerializeField] private Transform FirePointSolar9;
    [SerializeField] private Transform FirePointSolar10;
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


    // Start is called before the first frame update
    void Start()
    {
        bossHP = 20;
        StartCoroutine(SolarLaser());
        canShoot = true;
        BFirePoint1 = GameObject.Find("BFirePoint1").transform;
        BFirePoint2 = GameObject.Find("BFirePoint2").transform;
        BFirePoint3 = GameObject.Find("BFirePoint3").transform;
        BFirePoint4 = GameObject.Find("BFirePoint4").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(timesHit == 25)
        {
            timesHit = 0;
            bossHP -= 1;
        }
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

    public void LaunchFighter()
    {
        StartCoroutine(ReinText());
        Instantiate(fighter, FirepointFigher1.position, FirepointFigher1.rotation);
        Instantiate(fighter, FirepointFigher2.position, FirepointFigher2.rotation);
    }
    private IEnumerator ReinText()
    {
        GameObject.Find("ReinTextSprite").GetComponent<SpriteRenderer>().enabled = true;
        yield return new WaitForSeconds(2);
        GameObject.Find("ReinTextSprite").GetComponent<SpriteRenderer>().enabled = false;
    }

    private IEnumerator SolarLaser()
    {
        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar1.position, FirePointSolar1.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar2.position, FirePointSolar2.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar3.position, FirePointSolar3.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar4.position, FirePointSolar4.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar5.position, FirePointSolar5.rotation);

        yield return new WaitForSeconds(1);

        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar6.position, FirePointSolar6.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar7.position, FirePointSolar7.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar8.position, FirePointSolar8.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar9.position, FirePointSolar9.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(solarLaser, FirePointSolar10.position, FirePointSolar10.rotation);
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
