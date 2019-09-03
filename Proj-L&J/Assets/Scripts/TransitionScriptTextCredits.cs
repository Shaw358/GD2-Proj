using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScriptTextCredits : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ChangeScales());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ChangeScalesPlus());
        }
    }

    public void Yeet()
    {
        StartCoroutine(ChangeScalesPlus());
    }


    public IEnumerator ChangeScales()
    {
        for (int i = 0; i < 14; i++)
        {
            transform.localScale -= new Vector3(0.09F, 0.09F, 0);
            yield return new WaitForSeconds(0.08f);

        }
    }

    public IEnumerator ChangeScalesPlus()
    {
        for (int i = 0; i < 14; i++)
        {
            transform.localScale += new Vector3(0.09F, 0.09F, 0);
            yield return new WaitForSeconds(0.08f);
        }
        SceneManager.LoadScene("PlayerSelectScene");
    }
}
