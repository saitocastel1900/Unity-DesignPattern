using System;
using UnityEngine;

public class Nurikabe : Enemy,IDisposable
{
    public Nurikabe(string name,int hp)
    {
        _name = name;
        _hp = hp;
    }

    public override string GetName() => this.name;
    public override int GetHp() => this._hp;

    public override void Attack(int damaged)
    {
        Debug.Log($"{this._name}へ攻撃");
        _hp -= damaged;
        if (this._hp <= 0) this.Dispose();
    }
    
    public void Dispose()
    {
        Debug.Log($"{this._name}は倒されました");
    }
}
