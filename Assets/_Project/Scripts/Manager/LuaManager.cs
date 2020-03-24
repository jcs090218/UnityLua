/**
 * $File: LuaManager.cs $
 * $Date: 2020-03-24 15:50:10 $
 * $Revision: $
 * $Creator: Jen-Chieh Shen $
 * $Notice: See LICENSE.txt for modification and distribution information
 *                   Copyright © 2020 by Shen, Jen-Chieh $
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;

/// <summary>
/// Manage the portal between C# and Lua communication.
/// </summary>
public class LuaManager : MonoBehaviour
{
    /* Variables */
    private static LuaManager _instance = null;

    private static LuaClient LUA_CLIENT = null;

    private LuaState luaState = null;

    /* Setter & Getter */

    public static LuaManager instance { get { return _instance; } }
    public LuaClient luaClient { get { return LUA_CLIENT; } }

    /* Functions */

    private void Awake()
    {
        _instance = this;
        LUA_CLIENT = this.gameObject.AddComponent<LuaClient>();
    }

    public void CallFunc(string file, string func, MonoBehaviour obj)
    {
        luaState = LuaClient.GetMainState();
        luaState.DoFile(file);

        try
        {
            luaState.Call(func, obj);
        }
        catch (System.Exception e)
        {
            // Awake中必须这样特殊处理异常
            luaState.ThrowLuaException(e);
        }
    }
}
