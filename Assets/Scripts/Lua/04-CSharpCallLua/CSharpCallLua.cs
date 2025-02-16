using UnityEngine;
using XLua;

public class CSharpCallLua : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LuaEnv env = new LuaEnv();
        env.DoString("require 'CSharpCallLua'");

        //int a = env.Global.Get<int>("a");
        //string str = env.Global.Get<string>("str");
        //bool isDie = env.Global.Get<bool>("isDie");
        //print(a);
        //print(str);
        //print(isDie);

        //Person p = env.Global.Get<Person>("person");
        //print(p.name + "-" + p.age + "-" + p.id);

        IPerson p = env.Global.Get<IPerson>("person");
        print(p.name + "-" + p.age);
        p.eat();
        env.Dispose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    class Person
    {
        public string name;
        public int age;
        public int id;
    }
    [CSharpCallLua]
    public interface IPerson
    {
        string name { get; set; }
        int age { get; set; }
        void eat();
    }
}
