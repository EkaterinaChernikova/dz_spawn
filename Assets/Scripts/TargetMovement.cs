using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private GameObject _wayPoint1;
    [SerializeField] private GameObject _wayPoint2;

    private Vector3 _currentPoint;
    private float _speed = 3.0f;

    private void Start()
    {
        _currentPoint = _wayPoint1.transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _currentPoint, _speed * Time.deltaTime);

        if (transform.position == _wayPoint1.transform.position)
        {
            _currentPoint = _wayPoint2.transform.position;
        }
        else if (transform.position == _wayPoint2.transform.position)
        {
            _currentPoint = _wayPoint1.transform.position;
        }
    }
}
