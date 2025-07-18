 using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnCenter;

    private EnemyPool _pool;
    private Vector3 _spawnPoint;

    private void Awake()
    {
        _spawnPoint = _spawnCenter.position;

        if (_pool == null)
        {
            _pool = FindObjectOfType<EnemyPool>();
        }
    }

    public void SpawnEnemy()
    {
        Enemy enemy = _pool.GetEnemy();
        enemy.transform.position = _spawnPoint;
        enemy.transform.rotation = Quaternion.Euler(0, GenerateRandomAngular(), 0);
    }

    private float GenerateRandomAngular()
    {
        float angularMin = 0.0f;
        float angularMax = 360.0f;
        float angular = Random.Range(angularMin, angularMax);

        return angular;
    }


}
