﻿using UnityEngine;

public class ParticlesFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;


    void Update()
    {
        transform.position = player.position + offset;
    }
}

