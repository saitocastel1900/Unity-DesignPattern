using System;
public class Observer2 : IObserver<int>
{
    private string _name;
    
    //コンストラクタでインスタンスにお名前を
    public Observer2(string name)
    {
        _name = name;
    }

    #region コールバック

    public void OnCompleted()
    {
        UnityEngine.Debug.Log($"{_name}が通知の受け取り完了");
    }

    public void OnError(Exception error)
    {
        UnityEngine.Debug.Log($"{_name}がエラーを受け取りました:{error.Message}");
    }

    public void OnNext(int value)
    {
        UnityEngine.Debug.Log($"{_name}の{value}");
    }

    #endregion
}