using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("delete", 0.5F);
    }

    private void delete()
    {
        Destroy(gameObject);
    }
}
