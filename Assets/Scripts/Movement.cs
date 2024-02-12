using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Movement : MonoBehaviour
{
    private const string Walk = nameof(Walk);

    private Animator _animator;
    private Transform _target;
    private float _movementSpeed = 2.0f;
    private readonly int _walk = Animator.StringToHash(Walk);

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool(_walk, true);
    }

    private void Update()
    {
        transform.rotation = Quaternion.LookRotation(_target.transform.position - transform.position);
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
