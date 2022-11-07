//生成したいクラスの共通インターフェースを定義

using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected string _name;
    protected int _hp;

    public abstract string GetName();
    public abstract int GetHp();
    public abstract void Attack(int damaged);
}
