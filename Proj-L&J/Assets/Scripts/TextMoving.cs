using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextMoving : MonoBehaviour
{
    private bool Wait;
    private float Speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Wait = true;
        StartCoroutine(SwitchScene());

    }

    // Update is called once per frame
    void Update()
    {
        if (Wait == false)
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }

    }

    IEnumerator SwitchScene()
    {
        yield return new WaitForSeconds(2);
        Wait = false;
        yield return new WaitForSeconds(67);
        GameObject.Find("Transition").GetComponent<TransitionScriptTextCredits>().Yeet();

    }
}
