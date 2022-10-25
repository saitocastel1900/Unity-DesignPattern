using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Debug.Log(Singleton3.Instance.Name);
                    Thread.Sleep(1);
                }
            });
            
            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Debug.Log(Singleton3.Instance.Name);
                    Thread.Sleep(1);
                }
            });
        }
    }
}
