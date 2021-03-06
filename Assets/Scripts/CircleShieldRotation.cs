﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleShieldRotation : MonoBehaviour
{
    [Tooltip("Movement speed per second")] [SerializeField] float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 1f, 0f), speed * Time.deltaTime);
    }
}