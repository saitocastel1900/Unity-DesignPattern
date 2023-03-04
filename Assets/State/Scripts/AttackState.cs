using UnityEngine;

public class AttackState : IState
{
    private Player _player;

    public AttackState(Player player)
    {
        _player = player;
    }

    public void Enter()
    {
        Debug.Log("AttackState Enter");
    }

    public void Update()
    {
        _player.StatetateMachine.TransitionTo(_player.StatetateMachine.idleState);
        Debug.Log("AttackState Update");
    }

    public void Exit()
    {
        Debug.Log("AttackState Exit");
    }
}
