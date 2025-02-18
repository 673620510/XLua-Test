using NUnit;
using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class CSharpCallLua : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    LuaEnv env;

    private void Awake()
    {
        env = new LuaEnv();
        env.DoString("require 'CSharpCallLua'");

        //����ȫ�ֻ�����������
        //int a = env.Global.Get<int>("a");
        //string str = env.Global.Get<string>("str");
        //bool isDie = env.Global.Get<bool>("isDie");
        //print(a);
        //print(str);
        //print(isDie);

        //����ȫ�ֵ�table
        //1.ͨ��class��struct
        //Person p = env.Global.Get<Person>("person");
        //print(p.name + "-" + p.age + "-" + p.id);

        //2.ͨ��interfaceӳ��
        //IPerson p = env.Global.Get<IPerson>("person");
        //print(p.name + "-" + p.age);
        //p.eat(12, 34);

        //3.ͨ��Dictionary��List
        //Dictionary<string, object> dict = env.Global.Get<Dictionary<string, object>>("person");
        //List<int> list = env.Global.Get<List<int>>("person");
        //foreach (string key in dict.Keys)
        //{
        //    print(key + "-" + dict[key]);
        //}
        //foreach (object o in list)
        //{
        //    print(o);
        //}

        //4.ͨ��LuaTable
        //LuaTable tab = env.Global.Get<LuaTable>("person");
        //print(tab.Get<string>("name"));
        //print(tab.Get<string>("age"));
        //print(tab.Length);
        //foreach (string key in tab.GetKeys())
        //{
        //    print(tab[key]);
        //}

        //����ȫ�ֺ���function
        //Action<int, int> act1 = env.Global.Get<Action<int, int>>("add");
        //act1(34, 56);
        //act1 = null;

        //1.ӳ�䵽ί��Delegate
        //Add add = env.Global.Get<Add>("add");
        //int resa, resb = 0;
        //int res = add(34, 78, out resa,ref resb);
        //print(res);
        //print(resa); 
        //print(resb);
        //add = null;

        //2.ӳ�䵽LuaFunction
        LuaFunction func = env.Global.Get<LuaFunction>("add");
        object[] os = func.Call(1, 2);
        foreach (object o in os)
        {
            print(o);
        }

    }
    [CSharpCallLua]
    public delegate int Add(int a, int b, out int resa, ref int resb);
    void Start()
    {
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
        void eat(int a, int b);
    }
}
