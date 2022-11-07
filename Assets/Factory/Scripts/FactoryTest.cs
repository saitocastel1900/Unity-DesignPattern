using UnityEngine;

public class FactoryTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var augerCreator = new AugerCreator();
        var auger=augerCreator.Create("鬼1",120);
        auger.Attack(120);
        
        var nurikabeCreator = new NurikabeCreator();
        var nurikabe=nurikabeCreator.Create("塗壁1",1200);
        nurikabe.Attack(10);
    }
}
