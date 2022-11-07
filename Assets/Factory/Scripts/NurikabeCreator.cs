

public class NurikabeCreator : EnemyCreator
{
    public override Enemy Create(string name, int hp)
    {
        Nurikabe enemy = new Nurikabe(name,hp);
        return enemy;
    }
}
