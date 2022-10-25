using UnityEngine;

public sealed class Singleton3
{
    private static readonly object Lock = new object();
    private static Singleton3 _instance;
    public static Singleton3 Instance
    {
        get
        {
            lock (Lock)
            {
                return _instance ??= new Singleton3();
            }
        }
    }
    
    public string Name { get; }
    private Singleton3()
    {
        Name = nameof(Singleton3);
        Debug.Log("コンストラクターが呼び出されました");
    }
}
