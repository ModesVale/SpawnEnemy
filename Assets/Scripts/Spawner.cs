 using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnCenter;

    private EnemyPool _pool;

    private void Awake()
    {
        if (_pool == null)
        {
            _pool = FindObjectOfType<EnemyPool>();
        }
    }

    private void Start()
    {
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        Vector3 spawnPoint = _spawnCenter.position;
        Enemy enemy = _pool.GetEnemy();
        enemy.transform.position = spawnPoint;
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
