﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Rise()
    {
        this.gameObject.GetComponent<Animator>().SetBool("isMoving", true);
        this.gameObject.GetComponent<Animator>().SetBool("toLeft", true);
    }
}
