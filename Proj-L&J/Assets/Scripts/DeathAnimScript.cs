using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Delete());
    }

    private IEnumerator Delete()
    {
        yield return new WaitForSeconds(0.7F);
        GameObject.Find("Transition").GetComponent<DeadTransition>().StartDeathTransition();
        Destroy(gameObject);
    }
}
