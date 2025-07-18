using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] private float _spawnColldown = 2f;

    private List<Spawner> _spawsners;

    private void Awake()
    {
        _spawsners = new List<Spawner>(FindObjectsOfType<Spawner>());
    }

    private void Start()
    {
        StartCoroutine(SpawnTimeCounter());
    }

    private IEnumerator SpawnTimeCounter()
    {
        while (true)
        {
            yield return new WaitForSeconds(_spawnColldown);
            Spawner spawner = _spawsners[Random.Range(0, _spawsners.Count)];
            spawner.SpawnEnemy();
        }
    }
}
