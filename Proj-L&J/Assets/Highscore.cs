using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    private TextMeshPro highScoreText; 
    // Start is called before the first frame update
    void Start()
    {
        highScoreText = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        highScoreText.text = "1. " + " \n2. " + "\n3. " + "\n4. " + "\n5. " + "\n6. " + "\n7. " + "\n8. " + "\n9. " + "\n10. ";
    }
}
