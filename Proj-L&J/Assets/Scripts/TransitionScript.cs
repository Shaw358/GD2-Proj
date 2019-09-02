using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionScript : MonoBehaviour
{

    public void Nibba()
    {
        StartCoroutine(ChangeScales());
    }
    public IEnumerator ChangeScales()
    {
        for (int i = 0; i < 14; i++)
        {
            transform.localScale += new Vector3(0.09F, 0.09F, 0);
            yield return new WaitForSeconds(0.1f);

        }
    }
}
