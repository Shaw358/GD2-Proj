using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlageText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeScale());
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject.Find("TransitionSprite").GetComponent<TransitionScript>().Nibba();
        }
    }

    public IEnumerator ChangeScale()
    {
        for (int i = 0; i < 100000000; i++)
        {
            transform.localScale += new Vector3(0.2F, 0.2F, 0);
            yield return new WaitForSeconds(0.4f);
            transform.localScale += new Vector3(-0.2F, -0.2F, 0);
            yield return new WaitForSeconds(0.4f);
        }
    }
}
