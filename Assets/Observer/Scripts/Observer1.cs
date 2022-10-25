using UnityEngine;

public class Observer1 : MonoBehaviour
{
    [SerializeField] private Subject1 _subject;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //購読
            _subject.Subscribe(ValueLog);
        }
    }

    private void ValueLog(int end)
    {
        Debug.Log(end);
    }
}