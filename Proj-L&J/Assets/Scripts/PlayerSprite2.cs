using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSprite2 : MonoBehaviour
{
    private bool Enlarge;
    private bool once;
    // Start is called before the first frame update
    void Start()
    {
        once = true;
        Enlarge = false;
    }

    public void changeBool2()
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
