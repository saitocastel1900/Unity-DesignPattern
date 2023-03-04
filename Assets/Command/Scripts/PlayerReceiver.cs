using UnityEngine;

/// <summary>
/// 命令を実行する（命令を受け取る）
/// </summary>
public class PlayerReceiver : MonoBehaviour,IReceiver
{
    public void Move(Vector3 pos)
    {
        transform.position += pos;
    }
}
