using UnityEngine;
using UnityEngine.Pool;

public class ParticlePool : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem _effect = null;
    
    private ObjectPool<ParticleSystem> _pool;

    private void Awake()
    {
        _pool = new ObjectPool<ParticleSystem>(
            createFunc: Create,
            actionOnGet: OnGetFromPool, // プールから取り出されたときの処理 
            actionOnRelease: OnReleaseToPool, // プールに戻したときの処理
            actionOnDestroy: OnDestroyPooledObject, // プールがmaxSizeを超えたときの処理
            collectionCheck: true, // 同一インスタンスが登録されていないかチェックするかどうか
            maxSize: 100　//オブジェクトの最大許容量
        );
    }
    
    /// <summary>
    /// オブジェクトを生成する
    /// </summary>
    /// <returns></returns>
    private ParticleSystem Create()
    {
        return Instantiate(_effect, new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10)),
            Quaternion.identity);
    }
    
    /// <summary>
    /// 非アクティブのオブジェクトが合ったら表示する
    /// </summary>
    /// <param name="effect"></param>
    private void OnGetFromPool(ParticleSystem effect)
    {
        effect.gameObject.SetActive(true);
    }
    
    /// <summary>
    /// プールに返却時にオブジェクトを非表示にする
    /// </summary>
    /// <param name="effect"></param>
    private void OnReleaseToPool(ParticleSystem effect)
    {
        effect.gameObject.SetActive(false);
    }
    
    /// <summary>
    /// 非アクティブが多くなりすぎた時にオブジェクトを削除する
    /// </summary>
    /// <param name="effect"></param>
    private void OnDestroyPooledObject(ParticleSystem effect)
    {
        Destroy(effect);
    }
    
    /// <summary>
    ///プールからオブジェクトを持ってくる 
    /// </summary>
    public void Explosion()
    { 
        _pool.Get();
    }
    
    /// <summary>
    /// オブジェクトを返却する
    /// </summary>
    /// <param name="effect"></param>
    public void Delete(ParticleSystem effect)
    {
        _pool.Release(effect);
    }
}
