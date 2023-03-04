using UnityEngine;

public class StateTest1 : MonoBehaviour
{
    private enum State
    {
        Idle,
        Move,
        Jump
    }

    private State _state = State.Idle;

    private void Update()
    {
        OnStateChanged();
    }

    private void OnStateChanged()
    {
        switch (_state)
        {
            case State.Idle:
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    _state = State.Jump;
                }
                else if (Input.GetKey(KeyCode.W))
                {
                    _state = State.Move;
                }
                else
                {
                    Idle();
                }

                break;

            case State.Jump:
                Jump();
                break;

            case State.Move:
                Move();
                break;
        }
    }

    private void Idle()
    {
        Debug.Log("Idle!");
    }

    private void Move()
    {
        Debug.Log("Move!");
        _state = State.Idle;
    }

    private void Jump()
    {
        Debug.Log("Jump!");
        _state = State.Idle;
    }
}
