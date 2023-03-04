using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class StateTest2 : MonoBehaviour
{
    private enum State
    {
        Idle,
        Move,
        Jump
    }

    private ReactiveProperty<State> _stateProp= new ReactiveProperty<State>();
    
    private void Start()
    {
        _stateProp
            .DistinctUntilChanged()
            .Subscribe(_=>OnStateChanged())
            .AddTo(this.gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _stateProp.Value = State.Jump; 
        }
        else if (Input.GetKey(KeyCode.W))
        {
            _stateProp.Value = State.Jump;
        }
        else
        {
            _stateProp.Value = State.Idle;
        }
    }

    private void OnStateChanged()
    {
        switch (_stateProp.Value)
        {
            case State.Idle:
                Idle();
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
        _stateProp.Value = State.Idle;
    }

    private void Jump()
    {
        Debug.Log("Jump!");
        _stateProp.Value = State.Idle;
    }
}
