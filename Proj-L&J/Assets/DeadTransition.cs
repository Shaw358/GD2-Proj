using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartDeathTransition()
    {
        StartCoroutine(ChangeScales());
    }

    public IEnumerator ChangeScales()
    {
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 14; i++)
        {
            transform.localScale += new Vector3(0.09F, 0.09F, 0);
            yield return new WaitForSeconds(0.08f);
        }
        SceneManager.LoadScene("DeathScreen");
    }

}
