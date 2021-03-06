﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -------------------------------------------
// 委譲元 アクションメソッドの登録・削除（実行はしない）
// -------------------------------------------

public class ActionTest2 : MonoBehaviour
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
        inputManager.Idle += Talk;
        inputManager.Attack01 += PunchSound;
        inputManager.Attack02 += KickSound;
    }

    void OnDisable()
    {
        // アクションメソッドの削除
        inputManager.Idle -= Talk;
        inputManager.Attack01 -= PunchSound;
        inputManager.Attack02 -= KickSound;
    }

    void Talk()
    {
        Debug.Log("[ActionTest2] Talk...");
    }
    void KickSound()
    {
        Debug.Log("[ActionTest2] KickSound...");
    }
    void PunchSound()
    {
        Debug.Log("[ActionTest2] PunchSound...");
    }

}