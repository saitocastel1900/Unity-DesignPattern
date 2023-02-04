using UnityEngine;

public class Tester : MonoBehaviour
{
    [SerializeField] private ParticlePool _manager;
   
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _manager.Explosion();
        }
    }
}
