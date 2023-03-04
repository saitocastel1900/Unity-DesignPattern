using System.Collections.Generic;

/// <summary>
/// 伝達役
/// </summary>
public class Invoker
{
    private static Stack<ICommand> _commands = new Stack<ICommand>();
    
    public static void Execute(ICommand command)
    {
        command.Execute();
        _commands.Push(command);
    }

    public static void Undo()
    {
        if (_commands.Count > 0)
        {
            ICommand command = _commands.Pop();
            command.Undo();
        }
    }
}