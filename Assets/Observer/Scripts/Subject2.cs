using System;
using System.Collections.Generic;

public class Subject2 :IObservable<int>
{
    //observerをまとめて管理するリスト
    private List<IObserver<int>> _observers = new List<IObserver<int>>();
    
    //購読処理
    public IDisposable Subscribe(IObserver<int> observer)
    {
        //既に追加していなかったら
        if (!_observers.Contains(observer)) _observers.Add(observer);

        //購読を解除できるように返す
        return new Unsubscribe(_observers, observer);
    }

    // メッセージ発行
    public void SendNotice(int value) 
    {
        foreach (var observer in _observers)
        {
            //値を発行！
            observer.OnNext(value);
        }
    }

    //購読解除用クラス
    class Unsubscribe : IDisposable
    {
        private List<IObserver<int>> _observers;
        private IObserver<int> _observer;

        // コンストラクタ
        public Unsubscribe(List<IObserver<int>> observers, IObserver<int> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        // 購読を破棄する
        public void Dispose()
        {
            //リストから自分のObserverを削除
            _observers.Remove(_observer);
        }
    }
}