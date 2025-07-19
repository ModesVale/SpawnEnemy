using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _moveSpeed = 10;

    private Rigidbody _rigidbody;
    private Vector3 _direction;
    private Transform _target;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_target == null) return;

        _direction = (_target.position - transform.position).normalized;
        transform.rotation = Quaternion.LookRotation(_direction);
        _rigidbody.velocity = _direction * _moveSpeed;
    }

    public void SetTraget(Transform target)
    {
        _target = target;      
    }
}
