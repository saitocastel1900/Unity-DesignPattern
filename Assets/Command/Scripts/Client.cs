using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 呼び出し側
/// </summary>
public class Client : MonoBehaviour
{
    [SerializeField] private Button _rightMoveButton;
    [SerializeField] private Button _leftMoveButton;
    [SerializeField] private Button _undoButton;

    [SerializeField] private PlayerReceiver _receiver;
    
    private void Start()
    {
        _rightMoveButton.onClick.AddListener(LeftMove);
        _leftMoveButton.onClick.AddListener(RightMove);
        _undoButton.onClick.AddListener(Undo);
    }

    private void LeftMove()
    {
        ICommand command = new MoveCommand(_receiver,Vector3.left);
        Invoker.Execute(command);
    }

    private void RightMove()
    {
        ICommand command = new MoveCommand(_receiver,Vector3.right);
        Invoker.Execute(command);
    }

    private void Undo()
    {
        Invoker.Undo();
    }
}
