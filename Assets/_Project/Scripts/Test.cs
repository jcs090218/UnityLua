/**
 * $File: Test.cs $
 * $Date: 2020-03-24 15:46:23 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information
 *                   Copyright © 2020 by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Test script, mainly test for Lua script.
/// </summary>
public class Test : MonoBehaviour
{
    /* Variables */

    /* Setter & Getter */

    /* Functions */

    private void Start()
    {
        LuaManager.instance.CallFunc("Test.lua", "Test.Start", this);
    }

    private void Update()
    {
        LuaManager.instance.CallFunc("Test.lua", "Test.Update", this);
    }
}
