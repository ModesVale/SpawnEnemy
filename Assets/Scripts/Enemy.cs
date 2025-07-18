using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _moveSpeed = 10;

    private Rigidbody _rigidbody;
    private Vector3 _direction;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _direction * _moveSpeed;
    }

    public void Move(Vector3 direction)
    {
        _direction = direction;
        transform.rotation = Quaternion.LookRotation(_direction);      
    }
}
