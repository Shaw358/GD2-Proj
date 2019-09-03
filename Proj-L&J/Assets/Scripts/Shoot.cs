using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private Transform Firepoint1;
    private Transform Firepoint;
    private bool canShoot;

    [SerializeField] private GameObject PlayerBullet;
    // Start is called before the first frame update
    void Start()
    {
        canShoot = true;
        Firepoint = GameObject.Find("Firepoint").transform;
        Firepoint1 = GameObject.Find("Firepoint1").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Firepoint);
        if (Input.GetKeyDown(KeyCode.Space) && canShoot == true)
        {
            StartCoroutine(ShootBullet());
        }
    }

    private IEnumerator ShootBullet()
    {
        canShoot = false;
        Instantiate(PlayerBullet, Firepoint.position, Firepoint.rotation);
        Instantiate(PlayerBullet, Firepoint1.position, Firepoint1.rotation);
        yield return new WaitForSeconds(0.1F);
        canShoot = true;
    }
}
