using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLooper : MonoBehaviour
{
    public AudioSource audioData;
    public AudioSource Loop;

    void Start()
    {
        audioData.Play(0);
        StartCoroutine(PlayLoop());
        Debug.Log("started");
    }
    private IEnumerator PlayLoop()
    {
        yield return new WaitForSecondsRealtime(64);
        Loop.Play(0);
    }
}