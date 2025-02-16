using UnityEngine;
using XLua;

public class HelloWorld01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private LuaEnv luaenv;

    void Start()
    {
        luaenv = new LuaEnv();

        //luaenv.DoString("print('Hello world!')");
        luaenv.DoString("CS.UnityEngine.Debug.Log('Hello world')");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        luaenv.Dispose();
    }
}
