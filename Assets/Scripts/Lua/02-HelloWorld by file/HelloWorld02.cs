using UnityEngine;
using XLua;
public class HelloWorld02 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    LuaEnv luaEnv;
    void Start()
    {
        //TextAsset ta = Resources.Load<TextAsset>("helloworld.lua");
        luaEnv = new LuaEnv();
        //luaEnv.DoString(ta.ToString());
        luaEnv.DoString("require 'helloworld'");
        luaEnv.Dispose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
