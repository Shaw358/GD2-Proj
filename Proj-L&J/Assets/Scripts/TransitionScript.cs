using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(ChangeScales());
        }
    }
    public IEnumerator ChangeScales()
    {
        for (int i = 0; i < 14; i++)
        {
            transform.localScale += new Vector3(0.09F, 0.09F, 0);
            yield return new WaitForSeconds(0.08f);
        }
        SceneManager.LoadScene("OpeningCreditsScene");
    }

}
