﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_LightTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.LightType));
		L.RegVar("Spot", get_Spot, null);
		L.RegVar("Directional", get_Directional, null);
		L.RegVar("Point", get_Point, null);
		L.RegVar("Area", get_Area, null);
		L.RegVar("Rectangle", get_Rectangle, null);
		L.RegVar("Disc", get_Disc, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<UnityEngine.LightType>.Check = CheckType;
		StackTraits<UnityEngine.LightType>.Push = Push;
	}

	static void Push(IntPtr L, UnityEngine.LightType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(UnityEngine.LightType), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Spot(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.LightType.Spot);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Directional(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.LightType.Directional);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Point(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.LightType.Point);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Area(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.LightType.Rectangle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Rectangle(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.LightType.Rectangle);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Disc(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.LightType.Disc);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.LightType o = (UnityEngine.LightType)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

