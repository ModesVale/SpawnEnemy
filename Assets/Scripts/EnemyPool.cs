using UnityEngine;
using UnityEngine.Pool;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private int _poolCapacity = 10;
    [SerializeField] private int _poolMaxSize = 100;

    private ObjectPool<Enemy> _pool;

    private void Awake()
    {
        _pool = new ObjectPool<Enemy>(
            createFunc: () => Instantiate(_enemy),
            actionOnGet: (instance) => ActionOnGet(instance),
            actionOnRelease: ActionOnRelese,
            actionOnDestroy: (instance) => Destroy(instance),
            collectionCheck: true,
            defaultCapacity: _poolCapacity,
            maxSize: _poolMaxSize);
    }

    private void ActionOnGet(Enemy instance)
    {

    }

    private void ActionOnRelese(Enemy instance)
    {

    }

    public Enemy GetEnemy()
    {
        return _pool.Get();
    }
}
