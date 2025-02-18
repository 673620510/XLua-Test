using UnityEngine;
using XLua;

public class LuaCallCSharp : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    LuaEnv luaEnv;
    private void Awake()
    {
        luaEnv = new LuaEnv();
        luaEnv.DoString("require 'LuaCallCSharp'");
    }
    void Start()
    {
        luaEnv.Dispose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
