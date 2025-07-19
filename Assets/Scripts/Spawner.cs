using UnityEngine;
using UnityEngine.Pool;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _mark;
    [SerializeField] private int _poolCapacity = 10;
    [SerializeField] private Transform _spawnCenter;

    private ObjectPool<Enemy> _pool;
    private Vector3 _spawnPoint;

    private void Awake()
    {
        _spawnPoint = _spawnCenter.position;

        _pool = new ObjectPool<Enemy>(
           createFunc: () => Instantiate(_enemy),
           actionOnGet: (instance) => ActionOnGet(instance),
           actionOnRelease: null,
           actionOnDestroy: (instance) => Destroy(instance),
           collectionCheck: true,
           defaultCapacity: _poolCapacity);
    }

    public void ActionOnGet(Enemy instance)
    {
        instance.transform.position = _spawnPoint;
        instance.SetTraget(_mark);
    }

    public void SpawnEnemy()
    {
        _pool.Get();
    }

}
