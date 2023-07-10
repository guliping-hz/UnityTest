using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Startup
{
    static Startup()
    {
        //游戏启动的时候做一些初始化操作。
        Debug.Log("Startup and running...");
    }
}
