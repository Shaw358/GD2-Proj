using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite1 : MonoBehaviour
{
    private bool Enlarge;
    private bool once;
    // Start is called before the first frame update
    void Start()
    {
        once = true;
        Enlarge = true;
        transform.localScale += new Vector3(0.5F, 0.5F, 0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Enlarge == true)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2 = false;
            }
            else if(Enlarge == false)
            {
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2 = true;
            }
        }
        //SceneManager.LoadScene("SecondScene");

    }

    public void changeBool1()
    {
        if (Enlarge == false && once == true)
        {
            transform.localScale += new Vector3(0.5F, 0.5F, 0);
            Enlarge = true;
            once = false;
        }
        if (Enlarge == true && once == true)
        {
            transform.localScale += new Vector3(-0.5F, -0.5F, 0);
            Enlarge = false;
            once = false;
        }
        once = true;
    }
}
