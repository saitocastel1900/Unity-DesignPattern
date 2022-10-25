using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class Observable1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Button>()
            .OnClickAsObservable()
            .Subscribe(_=>Debug.Log("OnClick!"))
            .AddTo(this);

    }
}
