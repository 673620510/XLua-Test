using System.IO;
using System.Text;
using UnityEngine;
using XLua;

public class CreateLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LuaEnv env = new LuaEnv();
        env.AddLoader(MyLoader);
        env.DoString("require 'test007'");
        env.Dispose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private byte[] MyLoader(ref string filePath)
    {
        //print(filePath);
        //string s = "print(123)";
        //print(Application.streamingAssetsPath);
        string absPath = Application.streamingAssetsPath + "/" + filePath + ".lua.txt";
        return Encoding.UTF8.GetBytes(File.ReadAllText(absPath));
        //return Encoding.UTF8.GetBytes(s);
        //return null;
    }
}
