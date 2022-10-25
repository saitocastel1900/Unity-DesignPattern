using UnityEngine;

public class Test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //複数個値を受け取るクラスを生成
        var observerA = new Observer2("A");
        var observerB = new Observer2("B");

        //値を発行するクラス
        var subject = new Subject2();

        //購読処理
        var disposableA = subject.Subscribe(observerA);
        var disposableB = subject.Subscribe(observerB);
        
        //メッセージ発行
        subject.SendNotice(1);
        subject.SendNotice(2);
        subject.SendNotice(3);
        
        //購読解除
        disposableA.Dispose();
        disposableB.Dispose();
    }
}
