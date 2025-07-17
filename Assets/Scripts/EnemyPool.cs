using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private ObjectPool<Enemy> _pool;

    private void Awake()
    {
        //_pool = new ObjectPool<Enemy>();
    }
}
