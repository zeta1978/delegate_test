﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -------------------------------------------
// 委譲元 アクションメソッドの登録・削除（実行はしない）
// -------------------------------------------

public class ActionTest1 : MonoBehaviour
{

    private InputManager inputManager;

    void Awake()
    {
        // scriptの参照
        GameObject inputManagerObj = GameObject.Find("InputManager");
        if (inputManagerObj != null)
        {
            inputManager = inputManagerObj.GetComponent<InputManager>();
        }
        if (inputManager == null)
        {
            Debug.Log("Cannot find 'InputManager' script");
        }
    }

    void OnEnable()
    {
        // アクションメソッドの登録
        inputManager.Idle += Idle;
        inputManager.Attack01 += Run;
        inputManager.Attack01 += Punch;
        inputManager.Attack02 += Jump;
        inputManager.Attack02 += Kick;
    }

    void OnDisable()
    {
        // アクションメソッドの削除
        inputManager.Idle -= Idle;
        inputManager.Attack01 -= Run;
        inputManager.Attack01 -= Punch;
        inputManager.Attack02 -= Jump;
        inputManager.Attack02 -= Kick;
    }

    void Idle()
    {
        Debug.Log("[ActionTest1] Idle...");
    }
    void Run()
    {
        Debug.Log("[ActionTest1] Run...");
    }
    void Jump()
    {
        Debug.Log("[ActionTest1] Jump...");
    }
    void Kick()
    {
        Debug.Log("[ActionTest1] Kick...");
    }
    void Punch()
    {
        Debug.Log("[ActionTest1] Punch...");
    }

}
