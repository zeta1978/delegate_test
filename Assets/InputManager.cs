﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; // Actionに必要

// -------------------------------------------
// 委譲先 アクションメソッドを実行する
// -------------------------------------------

public class InputManager : MonoBehaviour {

    public event Action Idle;
    public event Action Attack01;
    public event Action Attack02;

    void Update () {
        if (Input.GetKeyDown (KeyCode.Space) && Idle != null) {
            Idle ();
        }
        if (Input.GetKeyDown (KeyCode.F1) && Attack01 != null) {
            Attack01 ();
        }
        if (Input.GetKeyDown (KeyCode.F2) && Attack02 != null) {
            Attack02 ();
        }
    }
}