
public class AugerCreator : EnemyCreator
{
    public override Enemy Create(string name, int hp)
    {
        Enemy enemy = new Auger(name,hp);
        return enemy;
    }
}
