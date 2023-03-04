using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    private Player _player;
    
    public IdleState(Player player)
    {
        _player = player;
    }
    
    public void Enter()
    {
        Debug.Log("IdleState Enter");
    }

    public void Update()
    {
        if (_player.IsAttacked)
        {
            _player.StatetateMachine.TransitionTo(_player.StatetateMachine.attackState);
        }
        Debug.Log("IdleState Update");
    }

    public void Exit()
    {
        Debug.Log("IdleState Exit");
    }
}
