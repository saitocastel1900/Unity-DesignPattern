using UniRx;
using UnityEngine;

public class Subject3 : MonoBehaviour
{
    private Subject<Unit> _subject = new Subject<Unit>();

    public void OnClickButton()
    {
        _subject.OnNext(Unit.Default);
    }

    void Start()
    {
        _subject
            .Subscribe(_ => Debug.Log("PushButton")).AddTo(this);
    }
}
