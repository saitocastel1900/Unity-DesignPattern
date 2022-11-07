//ファクトリクラス
//Enemyクラスを生成する際のインターフェースを礼儀

public abstract class EnemyCreator
{
    public abstract Enemy Create(string name,int hp);
}
