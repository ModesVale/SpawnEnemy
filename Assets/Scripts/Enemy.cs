using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _pushPower = 10;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move(_pushPower);
    }

    public void Move(int pushPower)
    {
        
        _rigidbody.AddForce(transform.forward * pushPower, ForceMode.Force);
    }
}
