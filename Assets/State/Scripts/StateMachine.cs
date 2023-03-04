public class StateMachine
{
    private IState state;

    public AttackState attackState;
    public IdleState idleState;

    public StateMachine(Player player)
    {
        attackState = new AttackState(player);
        idleState = new IdleState(player);
    }

    public void Initialize(IState state)
    {
        this.state = state;
        state.Enter();
    }

    public void TransitionTo(IState nextState)
    {
        state.Exit();
        state = nextState;
        nextState.Enter();
    }

    public void Update()
    {
         state?.Update();
    }
}
