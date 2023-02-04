using UnityEngine;

public class Particle : MonoBehaviour
{
    private ParticlePool _pool;

    private void Start()
    {
        _pool = GameObject.Find("ObjectPoolManager").gameObject.GetComponent<ParticlePool>();
    }

    //パーティクルの再生が終わった時に実行
    private void OnParticleSystemStopped()
    {
        _pool.Delete(this.GetComponent<ParticleSystem>());
    }
}
