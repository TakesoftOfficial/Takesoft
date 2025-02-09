﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionInvoker : MonoBehaviour
{
    public Animator anim;
    public string str;
    public bool isTrue;

    public ActionInvoker(Animator anim, string str, bool isTrue) 
    {
        this.anim = anim;
        this.str = str;
        this.isTrue = isTrue;
    }

    public void Invoke()
    {
        this.anim.SetBool(this.str, this.isTrue);
    }
}
