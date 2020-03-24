[![Build Status](https://travis-ci.com/jcs090218/UnityLua.svg?branch=master)](https://travis-ci.com/jcs090218/UnityLua)
[![Unity Engine](https://img.shields.io/badge/Unity%20Engine-2019.3.3f1-blue.svg)](https://unity3d.com/get-unity/download/archive)
[![Release Tag](https://img.shields.io/github/tag/jcs090218/UnityLua.svg?label=release)](https://github.com/jcs090218/UnityLua/releases/latest)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

# Unity Lua
> Use Lua scripting language in Unity to accomplish hot update/fix functionality.

Project built on top of the [tolua](https://github.com/topameng/tolua) by [topameng](https://github.com/topameng).

This is the minimal project that shows you how to use `tolua` in your
own project.

## Why use ToLua for your game?

When you came of hot-update, you would need a scripting language that can be
compile or use after the binary is built.

### Pros

* Hot update/fix - you are able to change game logic without compile from
C# to binary.
* Lua is easy to learn.

### Cons

* No auto-completion and debugging tool. (Maybe in the future?)
* You would have to do extra comilation every time you want to port a function
from C# to Lua programming interface.
* Unstable, easy to break.
* Slower than C# in general.

## About ToLua

Here is a quick start that teaches you to use `tolua` in under a minute.

* `Assets/ToLua/Editor/Custom/CustomSettings.cs`
* `Assets/ToLua/Source/LuaConst.cs`

These files are the only files that you need to be aware of to customize `tolua`.
Basically all the export and path settings are listed in these files.

Done!!!

## Examples

There are few files that you would need to see before you know how to use 
`tolua`'s functionality.

All C# & Lua scripts under `/Assets/_Project/Scripts` folder.

Done!!!
