using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerActivator : MonoBehaviour
{
    [SerializeField] private List<Spawner> _spawners;
    [SerializeField] private float _spawnColldown = 2f;

    private void Start()
    {
        StartCoroutine(SpawnTimeCounter());
    }

    private IEnumerator SpawnTimeCounter()
    {
        WaitForSeconds wait = new WaitForSeconds(_spawnColldown);

        while (enabled)
        {
            yield return wait;
            Spawner spawner = _spawners[Random.Range(0, _spawners.Count)];
            spawner.SpawnEnemy();
        }
    }
}
