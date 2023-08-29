using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Move : MonoBehaviour
{
    private const string Walk = nameof(Walk);

    private Animator _animator;
    private float _movementSpeed = 2.0f;
    public readonly int _walk = Animator.StringToHash(Walk);

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _animator.SetBool(_walk, true);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * _movementSpeed * Time.deltaTime);
    }
}
