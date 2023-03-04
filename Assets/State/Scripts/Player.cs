using UnityEngine;

public class Player : MonoBehaviour
{
    public StateMachine StatetateMachine;
    public bool IsAttacked = false;

    private void Start()
    {
        StatetateMachine = new StateMachine(this);
        StatetateMachine.Initialize(StatetateMachine.idleState);
    }

    private void Update()
    {
        IsAttacked = Input.GetKeyDown(KeyCode.Space);
        
        StatetateMachine.Update();
    }
}
