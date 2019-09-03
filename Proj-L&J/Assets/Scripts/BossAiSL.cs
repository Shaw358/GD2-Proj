using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAiSL : MonoBehaviour
{
    [SerializeField] private GameObject Laser;
    [SerializeField] private Transform SLFirepoint;

    public void FireLaserBurst()
    {
        StartCoroutine(SPBurst());
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
