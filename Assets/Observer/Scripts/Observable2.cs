using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class Observable2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     this.gameObject.GetComponent<Collider>().OnCollisionEnterAsObservable()
         .Subscribe(target => Debug.Log("OnHit!"))
         .AddTo(this);  
    }
}
