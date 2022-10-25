using UnityEngine;

public class Singleton1:SingletonMonoBehaviour<Singleton1>
{
    private void Awake()
    {
        #region Singleton

        if (this != Instance)
        {
            Debug.LogError("インスタンスが既に存在しています。インスタンスを一つにするためこのインスタンスを破棄します");
            Destroy(this);
            return;
        }
        #endregion
    }
}
