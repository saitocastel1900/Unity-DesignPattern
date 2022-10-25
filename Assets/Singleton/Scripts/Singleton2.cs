using UnityEngine;

public class Singleton2
{
    private static Singleton2 _instance = new Singleton2();
    public static Singleton2 Instance => _instance;
    public string Name;

    public Singleton2()
    {
        Name = "こんにちわ";
        Debug.Log("コンストラクターが呼び出されました");
    }
}