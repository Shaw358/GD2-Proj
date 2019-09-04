using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAiSL : MonoBehaviour
{
    [SerializeField] private GameObject Laser;
    [SerializeField] private Transform SLFirepoint;

    public void FireLaserBurst()
    {
<<<<<<< HEAD
        //SLFirepoint = GameObject.Find("BFirePointL").transform;
        //StartCoroutine(SPBurst());
=======
        StartCoroutine(SPBurst());
>>>>>>> fcd6a1890170e2c4ca400221c1cd981bafe72d75
    }

    public IEnumerator SPBurst()
    {
        int rot = -90;
        for (int i = 0; i < 13; i++)
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, rot);
            Instantiate(Laser, SLFirepoint.position, SLFirepoint.rotation);
            rot += 15;
            yield return new WaitForSeconds(0.15F);
        }
    }
}
