using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Subject1 : MonoBehaviour
{
    private Action<int> OnComplete;

    public void Subscribe(Action<int> _action)
    {
        OnComplete = _action;

        var v = Random.Range(0, 10);
        OnComplete?.Invoke(v); //イベント発行(登録された処理にメッセージを渡して実行
    }
}
